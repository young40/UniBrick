using PureMVC.Patterns.Mediator;
using TinaX;
using TinaX.UIKit;

namespace GameScript.Login
{
    public class LoginMediator: Mediator
    {
        public static string NAME = nameof(LoginMediator);
            
        public LoginMediator() : base(NAME)
        {
            
        }

        public override async void OnRegister()
        {
            base.OnRegister();

            var core = XCore.MainInstance.GetService<IUIKit>();

            await core.OpenUIAsync("Assets/UI/Login/Login.prefab");
        }
    }
}