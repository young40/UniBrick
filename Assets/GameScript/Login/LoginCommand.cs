using PureMVC.Interfaces;
using PureMVC.Patterns.Command;

namespace GameScript.Login
{
    public class LoginCommand: SimpleCommand
    {
        public static string NAME = nameof(LoginCommand);
        
        public override void Execute(INotification notification)
        {
            base.Execute(notification);
            
            GameFacade.Instance.RegisterMediator(new LoginMediator());
        }
    }
}