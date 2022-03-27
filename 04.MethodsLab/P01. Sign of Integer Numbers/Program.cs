using System;

namespace P01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main()
        {
            int numberInput = int.Parse(Console.ReadLine());
            CheckNumberType(numberInput);

            
        }
        static void CheckNumberType(int number)
        {
            string result = string.Empty;
            if (number > 0)
            {
                result = "positive";
            }
            else if (number < 0)
            {
                result = "negative";
            }
            else
            {
                result = "zero";
            }
            Console.WriteLine($"The number {number} is {result}.");
        }
    }
}
