using System;
using System.Linq;
using System.Collections.Generic;

namespace P03._Inventory
{
    internal class Program
    {
        static void Main()
        {
            List<string> journal = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Craft!")
            {
                string[] tokens = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string commandType = tokens[0];

                if (commandType == "Collect")
                {
                    string item = tokens[1];

                    if (journal.Contains(item))
                    {
                        continue;
                    }
                    else
                    {
                        journal.Add(item);
                    }
                }

                else if (commandType == "Drop")
                {
                    string item = tokens[1];

                    if (journal.Contains(item))
                    {
                        journal.Remove(item);
                    }
                    else
                    {
                        continue;
                    }
                }

                else if (commandType == "Combine Items")
                {
                    string[] items = tokens[1].Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();

                    if (journal.Contains(items[0]))
                    {

                        journal.Insert(journal.IndexOf(items[0]) + 1, items[1]);
                    }

                    else
                    {
                        continue;
                    }
                }

                else if (commandType == "Renew")
                {
                    string item = tokens[1];

                    if (journal.Contains(item))
                    {
                        string temp = item;
                        journal.Remove(item);
                        journal.Add(temp);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
