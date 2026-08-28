using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwarenessBot.Bot
{
    internal class BotResponses
    {
        // Dictionary to hold responses in 
        private readonly Dictionary<string, string> _responses = new()
        {
            // Key = Value
            ["how are you"] = "I am good. Thank you for asking",
            ["your purpose"] = "My purpose is to provide you with safety tips to help you navigate the dangers online",
            ["what can i ask"] = "You can ask about password,phishing and browsing",
            ["password"] = "Use a unique, long passphrase for every account and protect them all with multi-factor authentication (MFA).",
            ["phishing"] = "Check the sender's actual email address carefully and never click links or download attachments from unexpected messages.",
            ["browsing"] = "Before entering sensitive data, always check that the website URL starts with \"https\" and has the padlock icon to ensure your connection is fully encrypted."

        };

        // Creating a default response incase nothing matches
        private readonly string _defaultResponse = "I didn't quite understand. Could you please rephase the question? "
            + "\n You can ask me about password safety,phising or safe browsing";


        // Method to find the key word and match it to a response
        public string GetResponseMatch(string input) {
            foreach (var item in _responses)
            {
                if (input.Contains(item.Key)) { 
                    return item.Value;
                }
            }
            // if nothing found return default response
            return _defaultResponse;
        }

    }
}
