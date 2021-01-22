using UnityEngine;

using TinaX;
using TinaX.UIKit;
using TinaX.VFSKit;

public class GameInit
{
    public static void Start()
    {
        Debug.Log("Hello from ILRuntime.");
        Debug.Log("Hello from ILRuntime.");

        var core = XCore.GetMainInstance();
        var uikit = core.Services.Get<IUIKit>();

        uikit.OpenUIAsync("Assets/UI/SuperPowerEntry/SuperPowerEntry.prefab", new SuperPowerEntry(), ExceptionHandler.EntityException);

        var vfs = core.Services.Get<IVFS>();
        vfs.LoadSceneAsync("Assets/Scenes/SuperPowerEntry.unity", (scene, exception) =>
        {
            if (exception == null)
            {
                scene.OpenScene();
            }
            else
            {
                Debug.LogError(exception);             
            }
        });
    }
}