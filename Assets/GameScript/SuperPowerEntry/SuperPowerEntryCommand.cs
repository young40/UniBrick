using GameScript.Login;
using PureMVC.Interfaces;
using PureMVC.Patterns.Command;
using SuperPowerEntry;
using UnityEngine;

public class SuperPowerEntryCommand: SimpleCommand
{
    public override async void Execute(INotification notification)
    {
        base.Execute(notification);
        
        GameFacade.Instance.RegisterProxy(new GameServerProxy());
        
        GameFacade.Instance.RegisterMediator(new SuperPowerEntryMediator());
        GameFacade.Instance.RegisterMediator(new SuperPowerEntrySceneMediator());

        Debug.LogError("Sending Login...");
        var param = new ParamLogin();
        var resp = await new RequestLogin().Send(param);
        
        Debug.LogError("Api Login Back.");
        Debug.LogError(resp.errCode);
        Debug.LogError(resp.errDesc);
    }
}