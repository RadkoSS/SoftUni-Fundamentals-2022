using System;
using System.Linq;
using System.Collections.Generic;

namespace P001.SchoolHW
{
    internal class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            for (int tempIndex = 0; tempIndex < input.Count; tempIndex++)
            {
                int nextNumberIndex = 0;

                if (tempIndex + 1 >= input.Count)
                {
                    break;
                }

                else
                {
                    nextNumberIndex = tempIndex + 1;
                }

                if (input[tempIndex] == input[nextNumberIndex])
                {
                    input[tempIndex] += input[nextNumberIndex];
                    input.RemoveAt(nextNumberIndex);
                    tempIndex = -1;
                }

            }
            Console.WriteLine(string.Join(' ', input));
        }
    }
}
