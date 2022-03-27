using System;

namespace P12._Two___Diamensional_Arrays
{
    internal class Program
    {
        static void Main()
        {
            int[,] numbers = new int[5, 3];
            
            Console.WriteLine("Enter numbers:");
            numbers = EnterNumbers(numbers);
            
            Console.WriteLine("The numbers are: ");
            PrintArray(numbers);

            Console.Write("Enter the number you are looking for: ");
            int desiredNumber = int.Parse(Console.ReadLine());
            int counter = searchArray(numbers, desiredNumber);

            if (counter != 0)
            {
                Console.WriteLine($"The number {desiredNumber} was found {counter} time/s in the array.");
            }
            else
            {
                Console.WriteLine("There is no such number in the array.");
            }

        }
        static int[,] EnterNumbers(int[,] emptyNumbersArray)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    emptyNumbersArray[i, k] = int.Parse(Console.ReadLine());
                }
            }
            return emptyNumbersArray;
        }
        static void PrintArray(int[,] numbersArray)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write($"{numbersArray[i, k]} ");
                }
            }
        }
        static int searchArray(int[,] numbers, int searchedNumber)
        {
            int counter = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    int currentNum = numbers[i, k];
                    if (currentNum == searchedNumber)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
