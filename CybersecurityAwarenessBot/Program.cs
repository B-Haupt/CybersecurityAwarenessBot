using CybersecurityAwarenessBot.Bot;

namespace CybersecurityAwarenessBot
{
    /// <summary>
    /// This is the entry point to the program. Its job is to create the chatbot and start the program. As all the logic is in the Bot classes.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method that creates the Chatbot object and then calls it run method to start the project.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        static void Main(string[] args)
        {
            new ChatBot().RunChatBot();

        }
    }
}