using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using TinaX;
using TinaX.XILRuntime.Const;
using TinaX.XILRuntime.Internal;
using UnityEngine;

namespace Editor.BuildTool
{
    public static class BuildGameDLL
    {
        public static void Build(bool isDebug)
        {
            var assemblyName = "GameBrick";
            var workDir = Directory.GetParent(Application.dataPath).ToString();
            var projPath = Path.Combine(workDir, assemblyName + ".csproj");

            var dllList = FindDllFromCsProj(workDir, projPath);
            foreach (var dll in dllList)
            {
                Debug.LogWarning(dll);
            }
            Debug.LogError(dllList.Count);

            var csList = FindCsharpFromCsProj(workDir, projPath);
            foreach (var cs in csList)
            {
                Debug.LogWarning(cs);
            }
            Debug.LogError(csList.Count);


            var config = XConfig.GetConfig<XILRTConfig>(XILConst.ConfigPath_Resources);

            if (config == null)
            {
                Debug.LogError("Config file not found :" + XILConst.ConfigPath_Resources);
                return;
            }

            var dllPath = workDir + "/" + config.LoadAssemblies[0].AssemblyPath;
            var pdbPath = workDir + "/" + config.LoadAssemblies[0].SymbolPath;

            BuildingGameDllWithRoslyn(assemblyName, dllPath, pdbPath,
                csList, dllList, isDebug);
        }

        private static void BuildingGameDllWithRoslyn(string assemblyName, string dllPath, string pdbPath,
            List<string> csPaths, List<string> refDllPaths, bool isDebug)
        {
            var syntaxTrees = new List<SyntaxTree>();
            var syntaxParseOptions = new CSharpParseOptions(LanguageVersion.Latest);

            foreach (var cs in csPaths)
            {
                var content = File.ReadAllText(cs);

                var tree = CSharpSyntaxTree.ParseText(content, syntaxParseOptions);
                syntaxTrees.Add(tree);
            }

            var dllMetadataRefs = new List<MetadataReference>();
            foreach (var refDll in refDllPaths)
            {
                dllMetadataRefs.Add(MetadataReference.CreateFromFile(refDll));
            }

            var compilationOptions = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary,
                optimizationLevel: isDebug ? OptimizationLevel.Debug : OptimizationLevel.Release,
                warningLevel: 4, allowUnsafe: true);

            var compilation = CSharpCompilation.Create(assemblyName, syntaxTrees,  dllMetadataRefs, compilationOptions);
            var emitOption = new EmitOptions(debugInformationFormat: DebugInformationFormat.PortablePdb);

            var steamDll = new MemoryStream();
            var steamPdb = new MemoryStream();

            var rs = compilation.Emit(steamDll, steamPdb, options: emitOption);

            File.WriteAllBytes(dllPath, steamDll.GetBuffer());
            File.WriteAllBytes(pdbPath, steamPdb.GetBuffer());

            Debug.LogError($"Success: {rs.Success}");

            if (!rs.Success)
            {
                var fails = rs.Diagnostics.
                    Where(di => di.IsWarningAsError || di.Severity == DiagnosticSeverity.Error);

                foreach (var f in fails)
                {
                    Debug.LogError(f.ToString());
                }
            }
        }

        private static List<string> FindCsharpFromCsProj(string workDir, string projPath)
        {
            XNamespace ns = "http://schemas.microsoft.com/developer/msbuild/2003";

            var xml = XDocument.Load(projPath);

            var list = (from item in xml.Descendants(ns + "Compile")
                select item.Attribute("Include")?.Value.Replace("\\", "/")
                ).Distinct().ToList();

            var projectList = (from item in xml.Descendants(ns + "ProjectReference")
                select item.Attribute("Include")?.Value).ToList();
            foreach (var proj in projectList)
            {
                var dllProjPath = Path.Combine(workDir, proj);
                FindCsharpFromCsProj(workDir, dllProjPath).
                    ForEach(csInProj => list.Add(csInProj));
            }

            return list;
        }

        private static List<string> FindDllFromCsProj(string workDir, string projPath)
        {
            XNamespace ns = "http://schemas.microsoft.com/developer/msbuild/2003";

            var xml = XDocument.Load(projPath);

            var list = (from item in xml.Descendants(ns + "Reference")
                select item.Value).Distinct().ToList();

            var projectList = (from item in xml.Descendants(ns + "ProjectReference")
                select item.Attribute("Include")?.Value).ToList();
            foreach (var proj in projectList)
            {
                var dllProjPath = Path.Combine(workDir, proj);
                FindDllFromCsProj(workDir, dllProjPath).
                    ForEach(dllInProj => list.Add(dllInProj));

                // var projDll = Path.Combine(workDir, "Library ", "ScriptAssemblies", proj.Replace(".csproj", "dll"));
                // list.Add(projDll);
            }

            return list.Distinct().ToList();
        }
    }
}
