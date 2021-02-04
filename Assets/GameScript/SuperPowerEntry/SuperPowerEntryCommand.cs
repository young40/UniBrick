using PureMVC.Interfaces;
using PureMVC.Patterns.Command;
using SuperPowerEntry;

public class SuperPowerEntryCommand: SimpleCommand
{
    public override void Execute(INotification notification)
    {
        base.Execute(notification);
        
        GameFacade.Instance.RegisterProxy(new GameServerProxy());
        
        GameFacade.Instance.RegisterMediator(new SuperPowerEntryMediator());
        GameFacade.Instance.RegisterMediator(new SuperPowerEntrySceneMediator());
    }
}