using System;
using System.Text;

namespace P01.PasswordReset
{
    internal class Program
    {
        static void Main()
        {
            string wrongPassword = Console.ReadLine();

            string action;
            while ((action = Console.ReadLine()) != "Done")
            {
                string[] commands = action.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "TakeOdd")
                {
                    wrongPassword = TakeOddChars(wrongPassword);
                    Console.WriteLine(wrongPassword);
                }

                else if (commands[0] == "Cut")
                {
                    int index = int.Parse(commands[1]);
                    int lenght = int.Parse(commands[2]);

                    wrongPassword = CutString(wrongPassword, index, lenght);
                    Console.WriteLine(wrongPassword);
                }

                else if (commands[0] == "Substitute")
                {
                    string oldString = commands[1];
                    string newString = commands[2];

                    if (!wrongPassword.Contains(oldString))
                    {
                        Console.WriteLine("Nothing to replace!");
                        continue;
                    }
                    wrongPassword = SubstituteStrings(wrongPassword, oldString, newString);

                    Console.WriteLine(wrongPassword);
                }
            }

            Console.WriteLine($"Your password is: {wrongPassword}");
        }

        static string TakeOddChars(string wrongPassword)
        {
            StringBuilder rawPassword = new StringBuilder();

            for (int symbolNum = 1; symbolNum < wrongPassword.Length; symbolNum += 2)
            {
                rawPassword.Append(wrongPassword[symbolNum]);
            }

            return rawPassword.ToString();
        }

        static string CutString(string wrongPassword, int index, int lenght)
        {
            return wrongPassword.Remove(index, lenght);
        }

        static string SubstituteStrings(string wrongPassword, string oldString, string newString)
        {
            return wrongPassword.Replace(oldString, newString);
        }
    }
}