using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwarenessBot.Bot
{
    internal class ChatBox
    {
        // new instances of all the classes to use in the chatbox
        private readonly ConsoleDisplayManager _ui = new();
        private readonly LogoArt _logo;
        private readonly GreatingPlayer _player;
        private readonly InputValidator _validator = new();
        private readonly BotResponses _botResponses = new();
        private readonly UserProfile _user = new();

        // Array for exit responses from user
        private static readonly string[] ExitInput = { "exit", "quit", "bye", "end", "good bye" };

        //Constructor
        public ChatBox() { 
            _player = new GreatingPlayer(_ui);
            _logo = new LogoArt(_ui);
        }


        // run method to call in main and start the program
        public void RunChatBox() {
            // Ensure art is rendering in UTF-8 for logo
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Cybersecurity Awareness Bot";

            // Calling methods
            _player.PlayGreeting();
            _logo.DisplayLogo();
            HelloToUser();
            ConversionLoop();
            Goodbye();

        }

        // Method that greets the user and get 
        private void HelloToUser() {
            _ui.SectionHeader("Welcome");

            string userName = _ui.AskUser("Please input your name");
            while (!_validator.isValidInput(userName)) { 
                _ui.BotWarning("I didn't get your name. Please re-enter it for me.");
                userName = _ui.AskUser("What is your name?");
            }

            _user.Name = userName.Trim();

            _ui.BotReply($"Welcome, {_user.Name}! I'm a Cybersecurity Awareness Bot. My goal is to keep you safe online.");
            _ui.BotReply("You can ask me about password safety, phishing or safe browsing. Type 'exit' when you want to leave.");
            _ui.SectionFooter();


        }

        private void ConversionLoop() {
            while (true)
            {
                string rawUserInput = _ui.AskUser(_user.Name);

                if (!_validator.isValidInput(rawUserInput)){
                    _ui.BotWarning("You didn't type anything. Ask me about passwords, phishing or safe browsing.");
                    continue;
                }

                string input = _validator.NormaliseInput(rawUserInput);

                // Break out of the conversion loop
                if (ExitInput.Contains(input)) {
                    break;
                }

                // Increase question counter
                _user.QuestionsAsked++;
                _ui.Divider();
                _ui.BotReply(_botResponses.GetResponseMatch(input));
                _ui.Divider();

            }
        }

        // Goodbye method
        private void Goodbye() {
            _ui.SectionHeader("Goodbye");
            _ui.BotReply($"Stay safe out there, {_user.Name}! You asked {_user.QuestionsAsked} question(s) today.");
            _ui.SectionFooter();
        }


    }
}
