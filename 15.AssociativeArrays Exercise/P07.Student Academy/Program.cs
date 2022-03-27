using System;
using System.Linq;
using System.Collections.Generic;

namespace P07.Student_Academy
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, List<double>> studentsInformation = new Dictionary<string, List<double>>();

            ReadInformation(studentsInformation);

            PrintStudents(studentsInformation);

        }

        static void ReadInformation(Dictionary<string, List<double>> studentsInformation)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfRows; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!studentsInformation.ContainsKey(studentName))
                {
                    studentsInformation.Add(studentName, new List<double>());
                }

                studentsInformation[studentName].Add(studentGrade);
            }
        }

        static void PrintStudents(Dictionary<string, List<double>> studentsInformation)
        {
            foreach (KeyValuePair<string, List<double>> student in studentsInformation)
            {
                double studentAverageGrade = student.Value.Average();

                if (studentAverageGrade < 4.5)
                {
                    continue;
                }

                Console.WriteLine($"{student.Key} -> {studentAverageGrade:f2}");
            }
        }
    }
}
