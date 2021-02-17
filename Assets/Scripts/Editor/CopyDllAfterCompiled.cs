#if !NO_ILRUNTIME
using TinaX;
using TinaX.XILRuntime.Const;
using TinaX.XILRuntime.Internal;
using UnityEngine;

public class CopyDllAfterCompiled
{
    [UnityEditor.Callbacks.DidReloadScripts]
    static void CopyDLL()
    {
        var config = XConfig.GetConfig<XILRTConfig>(XILConst.ConfigPath_Resources);

        if (config == null)
        {
            Debug.LogError("Config file not found :" + XILConst.ConfigPath_Resources);
            return;
        }

        var dll = System.Environment.CurrentDirectory + "/" + config.LoadAssemblies[0].AssemblyPath;
        var pdb = System.Environment.CurrentDirectory + "/" + config.LoadAssemblies[0].SymbolPath;

        var srcDll = System.Environment.CurrentDirectory + "/Library/ScriptAssemblies/GameBrick.dll";
        var srcPdb = System.Environment.CurrentDirectory + "/Library/ScriptAssemblies/GameBrick.pdb";
        
        System.IO.File.Copy(srcDll, dll, true);
        System.IO.File.Copy(srcPdb, pdb, true);
        
        Debug.Log("GameScript DLL updated.");
    }
}
#endif