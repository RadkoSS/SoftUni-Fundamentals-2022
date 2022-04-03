using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02.MessageTranslator
{
    internal class Program
    {
        static void Main()
        {
            string regexPattern = @"(\!)(?<command>[A-Z][a-z]{2,})(\1)\:\[(?<text>[A-Za-z]{8,})\]";

            int numberOfTexts = int.Parse(Console.ReadLine());

            for (int text = 1; text <= numberOfTexts; text++)
            {
                string currentText = Console.ReadLine();

                Match matched = Regex.Match(currentText, regexPattern);

                if (matched.Success)
                {
                    string currentCommand = matched.Groups["command"].Value;
                    string matchedText = matched.Groups["text"].Value;

                    List<int> translatedList = TranslateText(matchedText);
                    Console.WriteLine($"{currentCommand}: {string.Join(' ', translatedList)}");
                }

                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }

        static List<int> TranslateText(string matchedText)
        {
            List<int> translatedMessage = new List<int>();

            foreach (char character in matchedText)
            {
                translatedMessage.Add(character);
            }

            return translatedMessage;
        }
    }
}
