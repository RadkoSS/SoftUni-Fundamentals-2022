using System;
using System.Text;

namespace P01.DecryptingCommands
{
    internal class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] commandArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commandArgs[0] == "Replace")
                {
                    text = text.Replace(commandArgs[1], commandArgs[2]);
                    Console.WriteLine(text);
                }

                else if (commandArgs[0] == "Cut")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);

                    if (IsIndexValid(text, startIndex, endIndex))
                    {
                        text = text.Remove(startIndex, endIndex - startIndex + 1);
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }

                else if (commandArgs[0] == "Make")
                {
                    string convertToType = commandArgs[1];

                    text = FlipText(text, convertToType);
                    Console.WriteLine(text);
                }

                else if (commandArgs[0] == "Check")
                {
                    string textToCheck = commandArgs[1];

                    if (text.Contains(textToCheck))
                    {
                        Console.WriteLine($"Message contains {textToCheck}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {textToCheck}");
                    }
                }

                else if (commandArgs[0] == "Sum")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]) + 1;

                    if (IsIndexValid(text, startIndex, endIndex))
                    {
                        string substring = text.Substring(startIndex, endIndex - startIndex);
                        int sum = GetSumOfChars(substring);
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }
            }
        }

        static bool IsIndexValid(string text, int startIndex, int endIndex)
        {
            return startIndex >= 0 & endIndex < text.Length;
        }

        static string FlipText(string text, string typeToConvertTo)
        {
            StringBuilder changedText = new StringBuilder();

            foreach (char symbol in text)
            {
                if (char.IsLetter(symbol))
                {
                    if (typeToConvertTo == "Upper")
                    {
                        changedText.Append(char.ToUpper(symbol));
                    }

                    else if (typeToConvertTo == "Lower")
                    {
                        changedText.Append(char.ToLower(symbol));
                    }
                }
                else
                {
                    changedText.Append(symbol);
                }
            }

            return changedText.ToString();
        }

        static int GetSumOfChars(string substring)
        {
            int sum = 0;

            foreach (char symbol in substring)
            {
                sum += symbol;
            }
            return sum;
        }
    }
}
