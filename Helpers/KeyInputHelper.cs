using UnityEngine;

namespace AutoNexus.Helpers
{
    public static class KeyInputHelper
    {
        public static KeyCode ParseKeyInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Key input cannot be empty");

            input = input.Trim().ToUpper();

            switch (input)
            {
                case "RETURN":
                case "ENTER":
                    return KeyCode.Return;
                case "SPACE":
                    return KeyCode.Space;
                case "ESCAPE":
                    return KeyCode.Escape;
                case "TAB":
                    return KeyCode.Tab;
                case "BACKSPACE":
                    return KeyCode.Backspace;
                case "DELETE":
                    return KeyCode.Delete;
            }

            if (input.StartsWith("F") && input.Length > 1)
            {
                if (int.TryParse(input.Substring(1), out int fKeyNumber))
                {
                    if (fKeyNumber >= 1 && fKeyNumber <= 12)
                    {
                        return (KeyCode)Enum.Parse(typeof(KeyCode), input);
                    }
                }
            }

            if (input.Length == 1)
            {
                char ch = input[0];
                if (char.IsDigit(ch))
                    return (KeyCode)Enum.Parse(typeof(KeyCode), $"Alpha{ch}");
                if (char.IsLetter(ch))
                    return (KeyCode)Enum.Parse(typeof(KeyCode), ch.ToString());
            }

            try
            {
                return (KeyCode)Enum.Parse(typeof(KeyCode), input, true);
            }
            catch
            {
                throw new ArgumentException($"Invalid key input: {input}");
            }
        }

        public static string SanitizeKeyInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return "";

            input = input.Trim().ToUpper();

            try
            {
                ParseKeyInput(input);
                return input;
            }
            catch
            {
                return "";
            }
        }
    }
}