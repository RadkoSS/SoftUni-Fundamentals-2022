using System;
using System.Linq;

namespace P02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] firstArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] secondArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < firstArr.Length; i++)
            {
                for (int j = 0; j < secondArr.Length; j++)
                {
                    if (firstArr[i] == secondArr[j])
                    {
                        Console.Write($"{firstArr[i]} ");
                    }
                }
            }
        }
    }
}
