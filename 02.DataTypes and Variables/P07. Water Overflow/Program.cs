using System;

namespace P07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int WaterTankCapacity = 255;
            int additions = int.Parse(Console.ReadLine());
            int totalWaterPoured = 0;
            for (int i = 1; i <= additions; i++)
            {
                int waterAdded = int.Parse(Console.ReadLine());
                totalWaterPoured += waterAdded;
                if (totalWaterPoured > WaterTankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    totalWaterPoured -= waterAdded;
                }
            }
            Console.WriteLine(totalWaterPoured);
        }
    }
}
