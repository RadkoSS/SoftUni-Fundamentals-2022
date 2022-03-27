using System;
using System.Linq;
using System.Collections.Generic;

namespace P04._List_Operations
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = tokens[0];

                if (cmdType == "Add")
                {
                    int numToAdd = int.Parse(tokens[1]);
                    numbers.Add(numToAdd);
                }

                else if (cmdType == "Insert")
                {
                    int numToAdd = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);

                    if (!IsIndexValid(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, numToAdd);
                }

                else if (cmdType == "Remove")
                {
                    int index = int.Parse(tokens[1]);

                    if (!IsIndexValid(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(index);
                }

                else if (cmdType == "Shift")
                {
                    string direction = tokens[1];
                    int count = int.Parse(tokens[2]);
                    int realCount = count % numbers.Count;

                    if (direction == "left")
                    {
                        ShiftLeft(numbers, realCount);
                    }

                    else if (direction == "right")
                    {
                        ShiftRight(numbers, realCount);
                    }
                }

            }

            Console.WriteLine(string.Join(' ', numbers));
        }
        static bool IsIndexValid(List<int> numbers, int index)
        {
            return index >= 0 && index < numbers.Count;
        }

        static List<int> ShiftLeft(List<int> numbers, int count)
        {

            for (int i = 0; i < count; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }

            return numbers;
        }

        static List<int> ShiftRight(List<int> numbers, int count)
        {

            for (int i = 0; i < count; i++)
            {
                numbers.Insert(0, numbers[numbers.Count - 1]);
                numbers.RemoveAt(numbers.Count - 1);
            }

            return numbers;
        }
    }
}
