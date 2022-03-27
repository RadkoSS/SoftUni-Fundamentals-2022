using System;

namespace P13._Printing_Two_Dimensional_Array
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers:");
            int[,] numbers = new int[4, 5];

            PrintArray(EnterNumbers(numbers));
        }
        static int[,] EnterNumbers(int[,] numbersArray)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    numbersArray[i, k] = int.Parse(Console.ReadLine());
                }
            }
            return numbersArray;
        }
        static void PrintArray(int[,] numbersArray)
        {
            Console.WriteLine("Printing the numbers:");
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    Console.Write($"{numbersArray[i, k]} ");
                }
            }
        }
    }
}
