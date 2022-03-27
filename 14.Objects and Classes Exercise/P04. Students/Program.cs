using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._Students
{
    internal class Program
    {
        static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = GetStudents(numberOfStudents).OrderByDescending(student => student.Grade).ToList();

            PrintStudents(students);

        }

        static List<Student> GetStudents(int numberOfStudents)
        {
            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {

                string[] currentStudentInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string firstName = currentStudentInfo[0];
                string lastName = currentStudentInfo[1];
                double grade = double.Parse(currentStudentInfo[2]);

                Student currentStudent = new Student(firstName, lastName, grade);

                students.Add(currentStudent);

            }
            return students;
        }

        static void PrintStudents(List<Student> studentList)
        {
            foreach (Student student in studentList)
            {
                Console.WriteLine(student);
            }
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
    }
}
