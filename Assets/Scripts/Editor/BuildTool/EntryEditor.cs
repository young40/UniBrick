using UnityEditor;

namespace Editor.BuildTool
{
    public class EntryEditor
    {
        [MenuItem("TinaX/BuildDll", priority = 9000)]
        public static void BuildDll()
        {
            BuildGameDLL.Build(true);
        }
    }
}