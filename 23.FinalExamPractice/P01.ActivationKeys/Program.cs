using System;
using System.Text;

namespace P01.ActivationKeys
{
    internal class Program
    {
        static void Main()
        {
            string rawActivationKey = Console.ReadLine();
            
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] commandArgs = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                string commandType = commandArgs[0];

                if (commandType == "Contains")
                {
                    string substring = commandArgs[1];
                    if (CheckIfStringIsContained(rawActivationKey, substring))
                    {
                        Console.WriteLine($"{rawActivationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                else if (commandType == "Flip")
                {
                    string typeToConvertTo = commandArgs[1];
                    int startIndex = int.Parse(commandArgs[2]);
                    int endIndex = int.Parse(commandArgs[3]);

                    rawActivationKey = FlipText(rawActivationKey, typeToConvertTo, startIndex, endIndex);
                    Console.WriteLine(rawActivationKey);
                }

                else if (commandType == "Slice")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);

                    rawActivationKey = SliceText(rawActivationKey, startIndex, endIndex);
                    Console.WriteLine(rawActivationKey);
                }
            }

            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }

        static bool CheckIfStringIsContained(string rawActivationKey, string textToLookFor)
        {
            return rawActivationKey.Contains(textToLookFor);
        }

        static string FlipText(string rawActivationKey, string typeToConvertTo, int startIndex, int endIndex)
        {
            StringBuilder changedKey = new StringBuilder();

            string textWithoutSubstring = rawActivationKey.Remove(startIndex, endIndex - startIndex);

            changedKey.Append(textWithoutSubstring);

            if (typeToConvertTo == "Upper")
            {
                changedKey.Insert(startIndex, rawActivationKey.Substring(startIndex, endIndex - startIndex).ToUpper());
            }

            else if (typeToConvertTo == "Lower")
            {
                changedKey.Insert(startIndex, rawActivationKey.Substring(startIndex, endIndex - startIndex).ToLower());
            }

            return changedKey.ToString();
        }

        static string SliceText(string rawActivationKey, int startIndex, int endIndex)
        {
            return rawActivationKey.Remove(startIndex, endIndex - startIndex);
        }
    }
}
