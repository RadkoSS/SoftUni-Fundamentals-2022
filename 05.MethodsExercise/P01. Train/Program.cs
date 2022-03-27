using System;

namespace P01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] people = new int[numberOfWagons];  
            int sum = 0;

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                sum += people[i];
            }
            
            Console.WriteLine(string.Join(' ', people));
            Console.WriteLine(sum);
        }
    }
}
