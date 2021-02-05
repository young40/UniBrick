using GameScript.Login;
using PureMVC.Interfaces;
using PureMVC.Patterns.Command;

namespace GameScript.Init
{
    public class CmdAppStartup: MacroCommand
    {
        public static string NAME = nameof(CmdAppStartup);

        protected override void InitializeMacroCommand()
        {
            base.InitializeMacroCommand();

            AddSubCommand(() => new SuperPowerEntryCommand());
        }

        public override void Execute(INotification notification)
        {
            base.Execute(notification);

            GameFacade.Instance.RegisterCommand(LoginCommand.NAME, () => new LoginCommand());
        }
    }
}
