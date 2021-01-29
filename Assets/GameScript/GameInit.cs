using UnityEngine;

using TinaX;
using TinaX.UIKit;
using TinaX.VFSKit;
 
#if !NO_ILRUNTIME 
public class GameInit
#else
public class GameInit: IXBootstrap 
#endif
{
    public static void Start()
    {
        Debug.Log("Hello from ILRuntime.");

        var core = XCore.GetMainInstance();
        var uikit = core.Services.Get<IUIKit>();

        uikit.OpenUIAsync("Assets/UI/SuperPowerEntry/SuperPowerEntry.prefab", new SuperPowerEntry.SuperPowerEntry(), ExceptionHandler.EntityException);

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

#if NO_ILRUNTIME    
    public void OnInit(IXCore core)
    {
    }

    public void OnStart(IXCore core)
    {
        Start();
    }

    public void OnQuit()
    {
    }

    public void OnAppRestart()
    {
    }
#endif
}