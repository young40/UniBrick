using UnityEditor;

namespace Editor.BuildTool
{
    public static class EntryEditor
    {
        [MenuItem("TinaX/BuildDll", priority = 9000)]
        public static void BuildDll()
        {
            EditorUtility.DisplayProgressBar("Build Game DLL", "Building in progress ...", 0.2f);
            BuildGameDLL.Build(true);
            EditorUtility.ClearProgressBar();
        }
    }
}