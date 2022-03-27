using System;
using System.Collections.Generic;

namespace P05.Multiply_Big_Number
{
    internal class Program
    {
        static void Main()
        {
            char[] firstNumber = Console.ReadLine().TrimStart('0').ToCharArray();

            int secondNumber = int.Parse(Console.ReadLine());

            if (secondNumber == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                List<string> result = new List<string>();

                int remainder = 0;

                for (int i = firstNumber.Length - 1; i >= 0; i--)
                {
                    int currentNumber = int.Parse(firstNumber[i].ToString());

                    remainder = currentNumber * secondNumber + remainder;

                    int resultFromCurrentMultiplication = remainder % 10;
                    result.Insert(0, resultFromCurrentMultiplication.ToString());

                    remainder /= 10;
                }

                if (remainder > 0)
                {
                    Console.WriteLine($"{remainder}{string.Join(string.Empty, result)}");
                }
                else
                {
                    Console.WriteLine(string.Join(string.Empty, result));
                }

            }
        }
    }
}
