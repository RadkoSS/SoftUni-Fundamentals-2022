using System;
using System.Collections.Generic;

namespace P01._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main()
        {
            List<int> attendances = new List<int>();
            
            int studentsNumber = int.Parse(Console.ReadLine());
            int lecturesNumber = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsNumber; i++)
            {
                int studentAttendance = int.Parse(Console.ReadLine());
                attendances.Add(studentAttendance);
            }

            double maxBonus = 0;
            double maxAttendance = 0;

            for (int i = 0; i < studentsNumber; i++)
            {
                double totalBonus = (double)attendances[i] / lecturesNumber * (5 + bonus);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxAttendance = attendances[i];
                }

            }
            
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");

        }
    }
}
