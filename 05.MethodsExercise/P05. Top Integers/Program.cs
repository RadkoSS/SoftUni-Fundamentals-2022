using System;
using System.Linq;

namespace P05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] topIntegers = new int[array.Length];
            int indexer = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currentNum = array[i];
                bool isTopInteger = true;

                for (int j = i + 1; j < array.Length; j++)
                {
                    int rightNum = array[j];

                    if (rightNum >= currentNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    topIntegers[indexer++] = currentNum;

                }
            }
            for (int i = 0; i < indexer; i++)
            {
                Console.Write($"{topIntegers[i]} ");
            }

        }
    }
}
