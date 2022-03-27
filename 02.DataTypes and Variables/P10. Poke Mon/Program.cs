using System;

namespace P10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int powerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionY = int.Parse(Console.ReadLine());

            double halfPowerN = powerN * 0.5;
            int pokeCount = 0;

            while (powerN >= distanceM)
            {
                powerN -= distanceM;
                pokeCount++;
                if (powerN == halfPowerN)
                {
                    if (exhaustionY > 0)
                    {
                        powerN /= exhaustionY;
                    }
                }
            }
            Console.WriteLine(powerN);
            Console.WriteLine(pokeCount);
        }
    }
}
