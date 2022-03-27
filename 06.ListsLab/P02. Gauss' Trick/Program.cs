using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            
            numbers = DoTrick(numbers);
            
            Console.WriteLine(string.Join(' ', numbers));

        }
        static List<int> DoTrick(List<int> numbersList)
        {
            int originalCount = numbersList.Count;
            
            for (int i = 0; i < originalCount / 2; i++)
            {
                numbersList[i] += numbersList[numbersList.Count - 1];
                numbersList.RemoveAt(numbersList.Count - 1);
            }

            return numbersList;
        }
    }
}
