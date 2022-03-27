using System;

namespace P08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numberOfKegs = byte.Parse(Console.ReadLine());
            double max = double.MinValue;
            string biggestKeg = string.Empty;
            for (int i = 1; i <= numberOfKegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > max)
                {
                    max = volume;
                    biggestKeg = model;
                }

            }
            Console.WriteLine(biggestKeg);
        }
    }
}
