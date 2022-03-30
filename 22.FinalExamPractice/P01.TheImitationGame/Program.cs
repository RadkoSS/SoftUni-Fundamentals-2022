using System;
using System.Linq;
using System.Text;

namespace P01.TheImitationGame
{
    internal class Program
    {
        static void Main()
        {
            string message = Console.ReadLine();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] commandArgs = command.Split('|', StringSplitOptions.RemoveEmptyEntries);

                string commandType = commandArgs[0];

                if (commandType == "Move")
                {
                    int numberOfLetters = int.Parse(commandArgs[1]);

                    message = MoveLetters(numberOfLetters, message);
                }
                else if (commandType == "Insert")
                {
                    int index = int.Parse(commandArgs[1]);
                    string value = commandArgs[2];

                    message = InsertAtIndex(index, value, message);
                }
                else if (commandType == "ChangeAll")
                {
                    string oldString = commandArgs[1];
                    string newString = commandArgs[2];

                    message = ChangeAllOccurrences(oldString, newString, message);
                }
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }

        static string MoveLetters(int numberOfLetters, string message)
        {
            StringBuilder movedLetters = new StringBuilder();

            string rawMessage = message.Remove(0, numberOfLetters);

            movedLetters.Append(rawMessage);

            movedLetters.Append(message.Substring(0, numberOfLetters));

            return movedLetters.ToString();
        }

        static string InsertAtIndex(int index, string value, string message)
        {
            return message.Insert(index, value);
        }

        static string ChangeAllOccurrences(string oldString, string newString, string message)
        {
            return message.Replace(oldString, newString);
        }
    }
}
