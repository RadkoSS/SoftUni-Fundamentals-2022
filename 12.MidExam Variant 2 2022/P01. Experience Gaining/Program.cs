using System;

namespace P01._Experience_Gaining
{
    internal class Program
    {
        static void Main()
        {
            double xpNeeded = double.Parse(Console.ReadLine());
            int battleCount = int.Parse(Console.ReadLine());

            bool xpGathered = false;

            double xpSum = 0;

            int counter = 0;

            for (int i = 1; i <= battleCount; i++)
            {
                double currentBatlleXP = double.Parse(Console.ReadLine());
                counter++;

                if (i % 3 == 0)
                {
                    currentBatlleXP *= 1.15;
                }

                else if (i % 5 == 0)
                {
                    currentBatlleXP *= 0.9;
                }

                else if (i % 15 == 0)
                {
                    currentBatlleXP *= 1.05;
                }

                xpSum += currentBatlleXP;

                if (xpSum >= xpNeeded)
                {
                    xpGathered = true;
                    break;
                }  
            }

            if (xpGathered)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {counter} battles.");
            }

            else
            {
                double neededExperience = xpNeeded - xpSum;
                Console.WriteLine($"Player was not able to collect the needed experience, {neededExperience:f2} more needed.");
            }

        }
    }
}
