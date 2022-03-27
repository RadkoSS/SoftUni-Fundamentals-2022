using System;
using System.Linq;

namespace P03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int[] firstArray = new int[numbersCount];
            int[] secondArray = new int[numbersCount];

            for (int rows = 0; rows < numbersCount; rows++)
            {
                int[] currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (rows % 2 == 0)
                {
                    firstArray[rows] = currentRow[0];
                    secondArray[rows] = currentRow[1];
                }
                else
                {
                    firstArray[rows] = currentRow[1];
                    secondArray[rows] = currentRow[0];
                }
            }
            Console.WriteLine(string.Join(' ', firstArray));
            Console.WriteLine(string.Join(' ', secondArray));
        }
    }
}
