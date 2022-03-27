using System;
using System.Linq;

namespace P11._Merging_Arrays
{
    internal class Program
    {
        static void Main()
        {
            int[] firstArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] resultArray = new int[firstArray.Length + secondArray.Length];

            for (int i = 0; i < firstArray.Length; i++)
            {
                resultArray[i] = firstArray[i];
            }
            
            for (int i = firstArray.Length, j = 0; i < resultArray.Length; i++, j++)
            {
                resultArray[i] = secondArray[j];
            }
            
            Console.WriteLine(string.Join(' ', resultArray));
        }
    }
}
