using System;
using System.Linq;

namespace P07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int equalNumbersCount = 1;
            int mostElements = 1;
            int sequentialNumbers = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    equalNumbersCount++;
                }
                else
                {
                    equalNumbersCount = 1;
                }
                if (equalNumbersCount > mostElements)
                {
                    mostElements = equalNumbersCount;
                    sequentialNumbers = numbers[i];
                }
            }
            
            //for (int i = 0; i < mostElements; i++)
            //{
            //    Console.Write($"{sequentialNumbers} "); -> Same as Array.Fill();
            //}
            
            int[] finalResult = new int[mostElements];
            Array.Fill(finalResult, sequentialNumbers);
            
            Console.WriteLine(string.Join(' ', finalResult));
        }
    }
}
