using GameScript.Init;
using PureMVC.Patterns.Facade;
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
        Debug.Log("Hello from GameInit.");

        GameFacade.Instance.Startup();
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