using System;

namespace P01.World_Tour
{
    internal class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] commandArgs = command.Split(':', StringSplitOptions.RemoveEmptyEntries);

                string commandType = commandArgs[0];

                if (commandType == "Add Stop")
                {
                    int index = int.Parse(commandArgs[1]);
                    string textToInsert = commandArgs[2];

                    if (IfIndexIsValid(index, text))
                    {
                        text = text.Insert(index, textToInsert);
                    }
                }

                else if (commandType == "Remove Stop")
                {
                    int firstIndex = int.Parse(commandArgs[1]);
                    int lastIndex = int.Parse(commandArgs[2]);

                    if (IfIndexIsValid(firstIndex, text) && IfIndexIsValid(lastIndex, text))
                    {
                        text = text.Remove(firstIndex, lastIndex - firstIndex + 1);
                    }
                }

                else if (commandType == "Switch")
                {
                    string oldText = commandArgs[1];
                    string newText = commandArgs[2];

                    if (text.Contains(oldText))
                    {
                        text = text.Replace(oldText, newText);
                    }
                }

                Console.WriteLine(text);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {text}");
        }
        static bool IfIndexIsValid(int index, string text)
        {
            if (index < 0 || index >= text.Length)
            {
                return false;
            }
            return true;
        }
    }
}
