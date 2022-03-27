using System;
using System.Linq;
using System.Collections.Generic;

namespace P03._Numbers
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            double average = numbers.Average();
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber > average)
                {
                    result.Add(currentNumber);
                }
            }

            result.Sort();
            result.Reverse();

            if (result.Count == 0)
            {
                Console.WriteLine("No");
            }

            else
            {
                for (int i = 0; i < result.Count; i++)
                {
                    Console.Write($"{result[i]} ");
                    if (i == 4)
                    {
                        break;
                    }
                }
            }

        }
    }
}
