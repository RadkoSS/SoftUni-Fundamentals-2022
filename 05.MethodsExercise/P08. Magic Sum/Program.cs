using System;
using System.Linq;

namespace P08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pairs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int magicNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < pairs.Length; i++)
            {
                for (int j = i + 1; j < pairs.Length; j++)
                {
                    int sum = pairs[i] + pairs[j];
                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"{pairs[i]} {pairs[j]}");
                    }
                }
            }

        }
    }
}
