using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace CybersecurityAwarenessBot.Bot
{
    internal class GreatingPlayer
    {
        // Stating the path to get greeting Bot file
        private const string GreetingPathway = @"Media\Bot.wav";
        private readonly ConsoleDisplayManager _ui;


        // Constructor of Greeting Player
        public GreatingPlayer(ConsoleDisplayManager ui) { 
            _ui = ui;              
        }

        public void PlayGreeting() {
            try
            {
                // Checking if the file exists
                if (!File.Exists(GreetingPathway))
                {
                    _ui.BotWarning("Error: Voice Greeting was skipped - audio file not found.");
                    return;

                }

                // Creating a SoundPlayer Object to play the wav file
                using var player = new SoundPlayer(GreetingPathway);
                player.Load();
                player.PlaySync();

            }
            catch (Exception ex) { 
                _ui.BotWarning("Error" + ex.Message);
            }
        }
    }
}
