using System;

namespace P01.StringGame
{
    internal class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] commandArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commandArgs[0] == "Change")
                {
                    string oldChar = commandArgs[1];
                    string newChar = commandArgs[2];

                    text = text.Replace(oldChar, newChar);
                    Console.WriteLine(text);
                }

                else if (commandArgs[0] == "Includes")
                {
                    string substring = commandArgs[1];

                    Console.WriteLine(text.Contains(substring));
                }

                else if (commandArgs[0] == "End")
                {
                    string substring = commandArgs[1];

                    Console.WriteLine(text.EndsWith(substring));
                }

                else if (commandArgs[0] == "Uppercase")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }

                else if (commandArgs[0] == "FindIndex")
                {
                    string charToFind = commandArgs[1];

                    Console.WriteLine(text.IndexOf(charToFind));
                }

                else if (commandArgs[0] == "Cut")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int count = int.Parse(commandArgs[2]);

                    text = text.Substring(startIndex, count);

                    Console.WriteLine(text);
                }
            }
        }
    }
}
