using System;

namespace P03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int fullCourses = peopleCount / elevatorCapacity;
            if (peopleCount % elevatorCapacity != 0)
            {
                fullCourses++;
            }
            Console.WriteLine(fullCourses);
        }
    }
}
