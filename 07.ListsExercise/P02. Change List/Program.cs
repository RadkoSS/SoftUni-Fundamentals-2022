using System;
using System.Linq;
using System.Collections.Generic;

namespace P02._Change_List
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

                if (cmdType == "Delete")
                {
                    int elementToDelete = int.Parse(cmdArgs[1]);

                    numbers.RemoveAll(x => x == elementToDelete);
                }

                else if (cmdType == "Insert")
                {
                    int elementToInsert = int.Parse(cmdArgs[1]);
                    int elementIndex = int.Parse(cmdArgs[2]);
                    
                    if (!IsIndexValid(numbers, elementIndex))
                    {
                        continue;
                    }
                    numbers.Insert(elementIndex, elementToInsert);
                }
                
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
        static bool IsIndexValid(List<int> numbers, int index)
        {
            return index >= 0 && index < numbers.Count;
        }
    }
}
