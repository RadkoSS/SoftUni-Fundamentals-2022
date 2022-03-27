using System;
using System.Collections.Generic;

namespace P03._House_Party
{
    internal class Program
    {
        static void Main()
        {
            List<string> namesList = new List<string>();
            int commandsCount = int.Parse(Console.ReadLine());

            while (commandsCount != 0)
            {
                string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string guestName = commands[0];

                if (commands.Length == 3)
                {
                    if (namesList.Contains(guestName))
                    {
                        Console.WriteLine($"{guestName} is already in the list!");
                    }

                    else
                    {
                        namesList.Add(guestName);
                    }
                }
                else if (commands.Length == 4)
                {
                    if (namesList.Contains(guestName))
                    {
                        namesList.Remove(guestName);
                    }

                    else
                    {
                        Console.WriteLine($"{guestName} is not in the list!");
                    }
                }

                commandsCount--;
            }

            Console.WriteLine(string.Join(Environment.NewLine, namesList));
        }
    }
}
