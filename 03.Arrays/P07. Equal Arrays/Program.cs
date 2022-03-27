using System;
using System.Linq;

namespace P07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int sum = 0;
            bool isDifferent = false;
            
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    sum+= firstArray[i];
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isDifferent = true;
                    break;
                }
            }
            if (!isDifferent) 
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

        }
    }
}
