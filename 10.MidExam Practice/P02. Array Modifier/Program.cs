using System;
using System.Linq;
using System.Collections.Generic;

namespace P02._Array_Modifier
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            
            int temporaryNum = 0;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string cmdType = tokens[0];

                if (cmdType == "swap")
                {
                    int firstIndex = int.Parse(tokens[1]);
                    int secondIndex = int.Parse(tokens[2]);

                    temporaryNum = numbers[firstIndex];
                    numbers[firstIndex] = numbers[secondIndex];
                    numbers[secondIndex] = temporaryNum;


                }

                else if (cmdType == "multiply")
                {
                    int firstIndex = int.Parse(tokens[1]);
                    int secondIndex = int.Parse(tokens[2]);

                    numbers[firstIndex] *= numbers[secondIndex];
                }

                else if (cmdType == "decrease")
                {
                    DecreaseNumbers(numbers);
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
        static List<int> DecreaseNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] -= 1;
            }
            return numbers;
        }
    }
}
