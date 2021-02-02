using GameScript.Init;
using PureMVC.Patterns.Facade;

public class GameFacade: Facade
{
    private static GameFacade _sInstance;
    
    public static GameFacade Instance
    {
        get
        {
            _sInstance ??= new GameFacade();

            return _sInstance;
        }
    }

    protected override void InitializeFacade()
    {
        base.InitializeFacade();
        
        RegisterCommand(CmdAppStartup.NAME, () => new CmdAppStartup());
    }

    public void Startup()
    {
        SendNotification(CmdAppStartup.NAME);
    }
}