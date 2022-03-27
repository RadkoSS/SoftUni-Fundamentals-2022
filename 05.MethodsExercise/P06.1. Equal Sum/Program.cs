using System;
using System.Linq;

namespace P06_1._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            int leftSum = 0;
            int rightSum = 0;
            bool isFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                leftSum = numbers.Take(i).Sum();

                rightSum = numbers.Skip(i + 1).Sum();

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}