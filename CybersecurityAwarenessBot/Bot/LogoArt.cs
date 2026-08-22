using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwarenessBot.Bot
{
    internal class LogoArt
    {

        private const string Logo = """

              ____      _                 ____        _   
             / ___|   _| |__   ___ _ __  | __ )  ___ | |_ 
            | |  | | | | '_ \ / _ \ '__| |  _ \ / _ \| __|
            | |__| |_| | |_) |  __/ |    | |_) | (_) | |_ 
             \____\__, |_.__/ \___|_|    |____/ \___/ \__|
                  |___/                                   
            """;

        private readonly ConsoleDisplayManager _ui;

        public LogoArt(ConsoleDisplayManager ui)
        {
            _ui = ui;
        }

        public void DisplayLogo()
        {
            _ui.ShowBanner(Logo, ConsoleColor.Green);
        }




    }
}
