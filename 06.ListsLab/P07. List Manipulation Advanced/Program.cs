using System;
using System.Linq;
using System.Collections.Generic;

namespace P07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = string.Empty;
            
            bool isChanged = false;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "Add")
                {
                    int numToAdd = int.Parse(cmdArgs[1]);
                    
                    numbers.Add(numToAdd);

                    isChanged = true;
                }

                else if (cmdType == "Remove")
                {
                    int numToRemove = int.Parse(cmdArgs[1]);
                   
                    numbers.Remove(numToRemove);

                    isChanged = true;
                }

                else if (cmdType == "RemoveAt")
                {
                    int indexToRemove = int.Parse(cmdArgs[1]);
                    
                    numbers.RemoveAt(indexToRemove);

                    isChanged = true;
                }

                else if (cmdType == "Insert")
                {
                    int numToInsert = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);
                    
                    numbers.Insert(index, numToInsert);
                    
                    isChanged = true;
                }

                else if (cmdType == "Contains")
                {
                    int numToCheck = int.Parse(cmdArgs[1]);
                    if (numbers.Contains(numToCheck))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }

                else if (cmdType == "PrintEven")
                {
                    Console.WriteLine(string.Join(' ', numbers.FindAll(x => x % 2 == 0)));
                }

                else if (cmdType == "PrintOdd")
                {
                    Console.WriteLine(string.Join(' ', numbers.FindAll(x => x % 2 != 0)));
                }

                else if (cmdType == "GetSum")
                {
                    Console.WriteLine(string.Join(' ', numbers.Sum()));
                }

                else if (cmdType == "Filter")
                {
                    string condition = cmdArgs[1];

                    int numToCheck = int.Parse(cmdArgs[2]);

                    Console.WriteLine(string.Join(' ', FilterByCondition(numbers, condition, numToCheck)));
                }
            }


            if (isChanged)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
        }
        static List<int> FilterByCondition(List<int> list, string condition, int numberToCheck)
        {
            switch (condition)
            {
                case "<":
                    return list.FindAll(x => x < numberToCheck);

                case ">":
                    return list.FindAll(x => x > numberToCheck);

                case ">=":
                    return list.FindAll(x => x >= numberToCheck);

                case "<=":
                    return list.FindAll(x => x <= numberToCheck);
            }
            return list;
        }
    }
}
