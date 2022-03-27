using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> resultList = new List<int>();

            for (int i = 0; i < Math.Min(firstList.Count, secondList.Count); i++)
            {
                resultList.Add(firstList[i]);
                resultList.Add(secondList[i]);
            }

            if (firstList.Count > secondList.Count)
            {
                resultList.AddRange(RemainingNumbers(firstList, secondList));
            }

            else if (secondList.Count > firstList.Count)
            {
                resultList.AddRange(RemainingNumbers(secondList, firstList));
            }

            Console.WriteLine(string.Join(' ', resultList));

        }
        static List<int> RemainingNumbers(List<int> longerList, List<int> shorterList)
        {
            List<int> result = new List<int>();

            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                result.Add(longerList[i]);
            }

            return result;
        }
    }
}
