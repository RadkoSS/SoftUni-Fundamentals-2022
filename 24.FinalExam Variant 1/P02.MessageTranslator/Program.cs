using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02.MessageTranslator
{
    internal class Program
    {
        static void Main()
        {

            Regex regex = new Regex(@"(!)(?<command>[A-Z][a-z]{2,})(\1):[(?<word>[A-Za-z]{8,})]");

            int textsToTranslate = int.Parse(Console.ReadLine());

            for (int i = 0; i < textsToTranslate; i++)
            {
                string currentText = Console.ReadLine();
                Match match = regex.Match(currentText);

                if (match.Success)
                {
                    string command = match.Groups["command"].Value;
                    string textToTranslate = match.Groups["word"].Value;

                    List<int> translation = TransalatedMessage(textToTranslate);

                    Console.WriteLine($"{command}: {string.Join(' ', translation)}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }

        static List<int> TransalatedMessage(string textToTranslate)
        {
            List<int> translatedMessage = new List<int>();

            foreach (var symbol in textToTranslate)
            {
                translatedMessage.Add(symbol);
            }

            return translatedMessage;
        }
    }
}