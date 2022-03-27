using System;
using System.Collections.Generic;

namespace P06.Courses
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] studentsInfo = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string courseName = studentsInfo[0];
                string studentName = studentsInfo[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }
                courses[courseName].Add(studentName);
            }

            PrintStudents(courses);

        }

        static void PrintStudents(Dictionary<string, List<string>> courses)
        {
            foreach (KeyValuePair<string, List<string>> course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (string student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
