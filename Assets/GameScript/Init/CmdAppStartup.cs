using PureMVC.Interfaces;
using PureMVC.Patterns.Command;

namespace GameScript.Init
{
    public class CmdAppStartup: MacroCommand
    {
        public const string NAME = "CmdAppStartup";

        protected override void InitializeMacroCommand()
        {
            base.InitializeMacroCommand();
            
            AddSubCommand(() => new CmdSuperPowerEntry());
        }
    }
}