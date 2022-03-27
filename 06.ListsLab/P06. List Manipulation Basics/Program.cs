using System;
using System.Linq;
using System.Collections.Generic;

namespace P06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "Add")
                {
                    int numToAdd = int.Parse(cmdArgs[1]);
                    numbers.Add(numToAdd);
                }

                else if (cmdType == "Remove")
                {
                    int numToRemove = int.Parse(cmdArgs[1]);
                    numbers.Remove(numToRemove);
                }

                else if (cmdType == "RemoveAt")
                {
                    int indexToRemove = int.Parse(cmdArgs[1]);
                    numbers.RemoveAt(indexToRemove);
                }

                else if (cmdType == "Insert")
                {
                    int numToInsert = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);
                    numbers.Insert(index, numToInsert);
                }

            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
