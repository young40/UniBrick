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
    }
}