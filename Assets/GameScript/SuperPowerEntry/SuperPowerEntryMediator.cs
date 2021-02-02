using PureMVC.Patterns.Mediator;
using TinaX;
using TinaX.UIKit;

namespace SuperPowerEntry
{
    public class SuperPowerEntryMediator: Mediator
    {
        private const string NAME = nameof(SuperPowerEntryMediator);
        
        public SuperPowerEntryMediator(): base(NAME)
        {
            var core = XCore.GetMainInstance();
            var uikit = core.Services.Get<IUIKit>();
            
            uikit.OpenUIAsync("Assets/UI/SuperPowerEntry/SuperPowerEntry.prefab", new SuperPowerEntry(), ExceptionHandler.EntityException);
        }
    }
}