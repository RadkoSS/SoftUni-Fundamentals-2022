using System;
using System.Linq;
using System.Collections.Generic;

namespace P01._Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

            Console.WriteLine(string.Join(' ', Iterations(numbers)));
            
        }
        static List<double> Iterations(List<double> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int nextIndex = 0;
                if (i + 1 > numbers.Count - 1)
                {
                    break;
                }
                else
                {
                    nextIndex = i + 1;
                }
                if (numbers[i] == numbers[nextIndex])
                {
                    numbers[i] += numbers[nextIndex];
                    numbers.RemoveAt(nextIndex);
                    i = -1;
                }
            }
            return numbers;
        }
    }
}
