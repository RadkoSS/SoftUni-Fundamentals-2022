using System;
using System.Linq;
using System.Collections.Generic;

namespace P02._Phone_Shop
{
    internal class Program
    {
        static void Main()
        {
            List<string> phonesStorage = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string commandType = tokens[0];

                if (commandType == "Add")
                {
                    string phone = tokens[1];

                    if (phonesStorage.Contains(phone))
                    {
                        continue;
                    }
                    else
                    {
                        phonesStorage.Add(phone);
                    }
                }

                else if (commandType == "Remove")
                {
                    string phone = tokens[1];

                    if (phonesStorage.Contains(phone))
                    {
                        phonesStorage.Remove(phone);
                    }
                    else
                    {
                        continue;
                    }
                }

                else if (commandType == "Bonus phone")
                {
                    string[] phones = tokens[1].Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();

                    if (phonesStorage.Contains(phones[0]))
                    {

                        phonesStorage.Insert(phonesStorage.IndexOf(phones[0]) + 1, phones[1]);
                    }

                    else
                    {
                        continue;
                    }
                }

                else if (commandType == "Last")
                {
                    string phone = tokens[1];

                    if (phonesStorage.Contains(phone))
                    {
                        string temp = phone;
                        phonesStorage.Remove(phone);
                        phonesStorage.Add(temp);
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", phonesStorage));
        }
    }
}
