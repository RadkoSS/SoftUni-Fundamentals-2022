using System;

namespace P04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte charactersCount = byte.Parse(Console.ReadLine());
            int totalSum = 0;
            for (int i = 1; i <= charactersCount; i++)
            {
                char currentSymbol = char.Parse(Console.ReadLine());
                totalSum += currentSymbol;
            }
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
