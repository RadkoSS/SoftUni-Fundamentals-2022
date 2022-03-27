using System;
using System.Linq;
using System.Collections.Generic;

namespace P07._Append_Arrays
{
    internal class Program
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

            Console.WriteLine(string.Join(' ', NumbersSorted(numbers)));
            
        }
        static List<string> NumbersSorted(string[] numbers)
        {
            List<string> sortedNumbers = new List<string>();

            foreach (string sequence in numbers)
            {
                sortedNumbers.AddRange(sequence.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList());
            }

            return sortedNumbers;
        }
    }
}
