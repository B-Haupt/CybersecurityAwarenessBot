using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwarenessBot.Bot
{
    internal class ConsoleDisplayManager
    {
       
        private const int Width = 70;

        // Styling for heading and dividor
        public void SectionHeader(string title)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(new string('=', Width));
            Console.WriteLine($"  {title.ToUpper()}");
            Console.WriteLine(new string('=', Width));
            Console.ResetColor();
            Console.WriteLine();
        }

        public void SectionFooter()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(new string('=', Width));
            Console.ResetColor();
            Console.WriteLine();
        }

        public void Divider()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string('-', Width));
            Console.ResetColor();
        }

        // Method that delays the Bots reply to user by 15 ms
        private void ResponseDelay(string message, int delayMs = 15) {
            foreach (char m in message) {
                Console.Write(m);
                Thread.Sleep(delayMs);
            }
            Console.WriteLine();
        }

        // Changes the colour of the bot responses and calls the delay method to print out console.
        public void BotReply(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Bot: ");
            Console.ResetColor();
            ResponseDelay(message);
            Console.WriteLine();
        }

        // Colour and calling of a warning message from the Bot
        public void BotWarning(string message) { 
            Console.ForegroundColor= ConsoleColor.Red;
            Console.Write("Bot: ");
            Console.ResetColor();
            Console.WriteLine(message);
            Console.WriteLine();
        }

        // Ask the user for input and if they don't input anything return a empty string
        public string AskUser(string message) { 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{message} : ");
            Console.ResetColor();  
            return Console.ReadLine() ?? string.Empty;
        }

    }
}
