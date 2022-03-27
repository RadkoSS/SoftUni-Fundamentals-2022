using System;
using System.Numerics;

namespace P11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            int highestQuality = 0;
            int highestSnowballSnow = 0;
            int highestSnowballTime = 0;
            
            BigInteger highestRating = BigInteger.Zero;

            for (int i = 1; i <= numberOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                
                if (snowballValue > highestRating)
                {
                    highestRating = snowballValue;
                    highestQuality = snowballQuality;
                    highestSnowballSnow = snowballSnow;
                    highestSnowballTime = snowballTime;
                }
            }
            Console.WriteLine($"{highestSnowballSnow} : {highestSnowballTime} = {highestRating} ({highestQuality})");
        }
    }
}
