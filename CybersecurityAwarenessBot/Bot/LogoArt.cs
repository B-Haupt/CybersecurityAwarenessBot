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
            ╔═╗┬ ┬┌┐ ┌─┐┬─┐┌─┐┌─┐┌─┐┬ ┬┬─┐┬┌┬┐┬ ┬  ╔═╗┬ ┬┌─┐┬─┐┌─┐┌┐┌┌─┐┌─┐┌─┐  ╔╗ ┌─┐┌┬┐
            ║  └┬┘├┴┐├┤ ├┬┘└─┐├┤ │  │ │├┬┘│ │ └┬┘  ╠═╣│││├─┤├┬┘├┤ │││├┤ └─┐└─┐  ╠╩╗│ │ │
            ╚═╝ ┴ └─┘└─┘┴└─└─┘└─┘└─┘└─┘┴└─┴ ┴  ┴   ╩ ╩└┴┘┴ ┴┴└─└─┘┘└┘└─┘└─┘└─┘  ╚═╝└─┘ ┴
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
