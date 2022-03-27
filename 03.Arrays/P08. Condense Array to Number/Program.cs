using System;
using System.Linq;

namespace P08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int originalLenght = numbers.Length;

            for (int i = 0; i < originalLenght - 1; i++)
            {
                int[] condensed = new int[numbers.Length - 1];
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    condensed[j] = numbers[j] + numbers[j + 1];
                }
                numbers = condensed;
            }
            Console.WriteLine(numbers[0]);
        }
    }
}
