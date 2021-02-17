using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Xml;
using System.Xml.Linq;
using UnityEngine;

namespace Editor.BuildTool
{
    public class BuildGameDLL
    {
        public static void Build(bool isDebug)
        {
            var workDir = Directory.GetParent(Application.dataPath).ToString();
            var projPath = Path.Combine(workDir, "GameBrick.csproj");

            var dllList = FindDllFromCSProj(workDir, projPath);
            foreach (var dll in dllList)
            {
                Debug.LogWarning(dll);
            }
            Debug.LogError(dllList.Count);

            var csList = FindCsharpFromCSProj(workDir, projPath);
            foreach (var cs in csList)
            {
                Debug.LogWarning(cs);
            }
            Debug.LogError(csList.Count);


        }

        private static List<string> FindCsharpFromCSProj(string workDir, string projPath)
        {
            XNamespace ns = "http://schemas.microsoft.com/developer/msbuild/2003";

            var xml = XDocument.Load(projPath);

            var list = (from item in xml.Descendants(ns + "Compile")
                select item.Attribute("Include")?.Value).Distinct().ToList();

            var projectList = (from item in xml.Descendants(ns + "ProjectReference")
                select item.Attribute("Include")?.Value).ToList();
            foreach (var proj in projectList)
            {
                var dllProjPath = Path.Combine(workDir, proj);
                FindCsharpFromCSProj(workDir, dllProjPath).
                    ForEach(csInProj => list.Add(csInProj));
            }

            return list;
        }

        private static List<string> FindDllFromCSProj(string workDir, string projPath)
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
                FindDllFromCSProj(workDir, dllProjPath).
                    ForEach(dllInProj => list.Add(dllInProj));

                // var projDll = Path.Combine(workDir, "Library ", "ScriptAssemblies", proj.Replace(".csproj", "dll"));
                // list.Add(projDll);
            }

            return list.Distinct().ToList();
        }
    }
}
