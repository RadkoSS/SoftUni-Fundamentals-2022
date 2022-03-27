using System;
using System.Linq;

namespace P04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int rotationOptimize = rotations % array.Length;

            for (int i = 0; i < rotationOptimize; i++)
            {
                int firstElement = array[0];
                for (int j = 0; j <= array.Length - 2; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] = firstElement;
            }
            Console.WriteLine(string.Join(' ', array));
        }
    }
}
