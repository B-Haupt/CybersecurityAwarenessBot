namespace CybersecurityAwarenessBot.Bot
{
    internal class ConsoleDisplayManager
    {

        private const int Width = 78;

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
        private void ResponseDelay(string message, int delayMs = 15)
        {
            foreach (char m in message)
            {
                Console.Write(m);
                Thread.Sleep(delayMs);
            }
           
        }

        // Changes the colour of the bot responses and calls the delay method to print out console.
        public void BotReply(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Bot: ");
            ResponseDelay(message);
            Console.ResetColor();
            Console.WriteLine();
        }

        // Colour and calling of a warning message from the Bot
        public void BotWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Bot: ");
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
        }

        // Ask the user for input and allows the user to return null
        public string AskUser(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{message}: ");
            Console.ResetColor();
            return Console.ReadLine() ?? string.Empty;
        }

        // Showing the logo to the console
        public void ShowBanner(string art, ConsoleColor colour)
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(art);
            Console.ResetColor();
        }

    }
}
