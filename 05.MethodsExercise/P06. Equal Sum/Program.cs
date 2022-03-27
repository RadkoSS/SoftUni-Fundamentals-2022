using System;
using System.Linq;

namespace P06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            //if (numbers.Length == 1)
            //{
            //    Console.WriteLine(0);
            //    return;
            //}
            //int biggestNum = int.MinValue;
            //int leftSum = 0;
            //int rightSum = 0;
            //int biggestNumIndex = 0;
            //bool isFound = false;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > biggestNum)
            //    {
            //        biggestNum = numbers[i];
            //        biggestNumIndex = i;
            //    }
            //    for (int j = biggestNumIndex - 1; j >= 0; j--)
            //    {
            //        leftSum += numbers[j];
            //    }
            //    for (int k = biggestNumIndex + 1; k < numbers.Length; k++)
            //    {
            //        rightSum += numbers[k];
            //    }
            //    if (leftSum == rightSum)
            //    {
            //        Console.WriteLine(biggestNumIndex);
            //        isFound = true;
            //        break;
            //    }
            //    else
            //    {
            //        leftSum = 0;
            //        rightSum = 0;
            //    }
            //}
            //if (!isFound)
            //{
            //    Console.WriteLine("no");
            //}
        }
    }
}
