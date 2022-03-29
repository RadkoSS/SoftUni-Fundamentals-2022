using System;
using System.Linq;
using System.Text;

namespace P01.Secret_Chat
{
    internal class Program
    {
        static void Main()
        {
            string message = Console.ReadLine();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Reveal")
            {
                string [] args = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string commandType = args[0];
                if (commandType == "InsertSpace")
                {
                    int index = int.Parse(args[1]);

                    message = InsertSpace(message, index);

                    Console.WriteLine(message);
                }

                else if (commandType == "Reverse")
                {
                    string substring = args[1];

                    if (message.Contains(substring))
                    {
                        message = ReverseSubstringInMessage(message, substring);
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                else if (commandType == "ChangeAll")
                {
                    string substring = args[1];

                    string replacement = args[2];

                    message = ReplaceAllOcurrences(message, substring, replacement);

                    Console.WriteLine(message);
                }
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
        
        static string InsertSpace(string message, int index)
        {
            return message.Insert(index, " ");
        }

        static string ReverseSubstringInMessage(string message, string substring)
        {
            StringBuilder newMessage = new StringBuilder();

            message = message.Remove(message.IndexOf(substring), substring.Length);

            newMessage.Append(message);
            newMessage.Append(ReverseStrings(substring));

            return newMessage.ToString();
        }

        static string ReverseStrings(string word)
        {
            char[] reversedWordArray = word.ToCharArray().Reverse().ToArray();

            return string.Join(string.Empty, reversedWordArray);
        }

        static string ReplaceAllOcurrences(string message, string oldString, string newString)
        {
            return message.Replace(oldString, newString);
        }
    }
}