using PureMVC.Patterns.Mediator;
using TinaX;
using TinaX.UIKit;
using UniRx;

namespace SuperPowerEntry
{
    public class SuperPowerEntryMediator: Mediator
    {
        private const string NAME = nameof(SuperPowerEntryMediator);

        private GameServerProxy m_GameServerProxy;

        public SuperPowerEntryMediator(): base(NAME, new SuperPowerEntry())
        {
            var core = XCore.GetMainInstance();
            var uikit = core.Services.Get<IUIKit>();
            
            uikit.OpenUIAsync("Assets/UI/SuperPowerEntry/SuperPowerEntry.prefab", view, ExceptionHandler.EntityException);
        }

        public override void OnRegister()
        {
            base.OnRegister();

            m_GameServerProxy = (GameServerProxy) GameFacade.Instance.RetrieveProxy(GameServerProxy.NAME);

            foreach (var server in m_GameServerProxy.ServerList)
            {
                view.AddGameServer(server);
            }
        }

        public SuperPowerEntry view
        {
            get => (SuperPowerEntry) ViewComponent;
        }
    }
}