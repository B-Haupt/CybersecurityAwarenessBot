using CybersecurityAwarenessBot.Bot;
using System;

namespace CybersecurityAwarenessBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ui = new ConsoleDisplayManager();
            var logo = new LogoArt(ui);
            logo.DisplayLogo();
            var voice = new GreatingPlayer(ui);
            voice.PlayGreeting();

            ui.SectionHeader("Welcome");
            ui.BotReply("Testing the typing effect and colours.");
            ui.Divider();
            ui.BotWarning("This is a warning.");
            string name = ui.AskUser("What is your name?");
            ui.BotReply($"Hello, {name}!");
            ui.SectionFooter();

            ui.Divider();


        }
    }
}