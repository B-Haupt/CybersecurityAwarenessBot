using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwarenessBot.Bot
{
    internal class InputValidator
    {
        // returns false for null, empty or whitespaces
        public bool isValidInput(string input) { 
            return !string.IsNullOrWhiteSpace(input);
        }

        // Trims the extra space and then puts it to lowercase
        public string NormaliseInput(string input) { 
            return input.Trim().ToLower();
        }

    }
}
