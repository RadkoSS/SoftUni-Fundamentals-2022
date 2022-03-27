using System;

namespace _6._1_Strong_number___alternative_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currNum = n;
            int factorialSum = 0;
            while (currNum != 0)
            {
                int factorial = 1;
                int remainder = currNum % 10;
                for (int i = 1; i <= remainder; i++)
                {
                    factorial *= i;
                }
                factorialSum += factorial;
                currNum /= 10;
            }
            if (factorialSum == n)
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