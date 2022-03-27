using System;

namespace P02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            GradeChecker(grade);
        }
        static void GradeChecker(double grade)
        {
            string gradeWithWords = string.Empty;
            if (grade >= 2 && grade <= 2.99)
            {
                gradeWithWords = "Fail";
            }
            else if (grade < 3.5)
            {
                gradeWithWords = "Poor";
            }
            else if (grade < 4.5)
            {
                gradeWithWords = "Good";
            }
            else if (grade < 5.5)
            {
                gradeWithWords = "Very good";
            }
            else if (grade <= 6)
            {
                gradeWithWords = "Excellent";
            }
            Console.WriteLine(gradeWithWords);
        }
    }
}
