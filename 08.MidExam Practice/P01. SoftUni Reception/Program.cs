using System;

namespace P01._SoftUni_Reception
{
    internal class Program
    {
        static void Main()
        {
            int firstWorkerEff = int.Parse(Console.ReadLine());
            int secondWorkerEff = int.Parse(Console.ReadLine());
            int thirdWorkerEff = int.Parse(Console.ReadLine());

            int totalEfficiency = firstWorkerEff + secondWorkerEff + thirdWorkerEff;

            int studentsCount = int.Parse(Console.ReadLine());
            int hours = 0;

            while (studentsCount > 0)
            {
                studentsCount -= totalEfficiency;
                hours++;
                if (hours % 4 == 0)
                {
                    hours++;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
