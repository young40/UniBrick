using PureMVC.Patterns.Mediator;
using TinaX;
using TinaX.UIKit;

namespace SuperPowerEntry
{
    public class SuperPowerEntryMediator: Mediator
    {
        private const string NAME = nameof(SuperPowerEntryMediator);

        private GameServerProxy m_GameServerProxy;

        public SuperPowerEntryMediator(): base(NAME, new SuperPowerEntryView())
        {

        }

        public override async void OnRegister()
        {
            base.OnRegister();

            var core = XCore.GetMainInstance();
            var uikit = core.Services.Get<IUIKit>();

            await uikit.OpenUIAsync("Assets/UI/SuperPowerEntry/SuperPowerEntry.prefab", view);

            m_GameServerProxy = (GameServerProxy) GameFacade.Instance.RetrieveProxy(GameServerProxy.NAME);

            foreach (var server in m_GameServerProxy.ServerList)
            {
                view.AddGameServer(server);
            }

            view.onAddGameServer = () => OpenAddGameServer();
        }

        public SuperPowerEntryView view
        {
            get => (SuperPowerEntryView) ViewComponent;
        }

        public void OpenAddGameServer()
        {
            var uikit = XCore.GetMainInstance().GetService<IUIKit>();

            uikit.OpenUIAsync("Assets/UI/SuperPowerEntry/SPEManageServer.prefab",
                    new AddGameServer(((name, ip, port) =>
                    {
                    }), () =>
                    {
                    }),
                    new OpenUIParam() {UseMask = true, CloseByMask = true}, ExceptionHandler.EntityException);
        }
    }
}
