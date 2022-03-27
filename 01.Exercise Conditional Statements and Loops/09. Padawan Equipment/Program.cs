using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double sabresCount = Math.Ceiling(studentsCount + studentsCount * 0.1);
            double freeBelts = studentsCount / 6;
            double beltsTotal = (studentsCount - freeBelts) * beltPrice;
            double saberTotal = sabresCount * saberPrice;
            double robeTotal = studentsCount * robePrice;
            double totalNeeded = beltsTotal + saberTotal + robeTotal;
            if (currentMoney >= totalNeeded)
            {
                Console.WriteLine($"The money is enough - it would cost {totalNeeded:f2}lv.");
            }
            else
            {
                double diff = totalNeeded - currentMoney;
                Console.WriteLine($"John will need {diff:f2}lv more.");
            }
        }
    }
}
