using System;

namespace _6._2_Strong_number___alternative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int factorialSum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                char currentDigit = number[i];
                int currNum = currentDigit - '0';
                int factorial = 1;
                for (int j = currNum; j > 0; j--)
                {
                    factorial *= j;
                }
                factorialSum += factorial;

            }
            if (factorialSum == int.Parse(number))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
