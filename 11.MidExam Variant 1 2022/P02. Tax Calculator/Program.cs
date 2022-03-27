using System;
using System.Linq;
using System.Collections.Generic;

namespace P02._Tax_Calculator
{
    internal class Program
    {
        static void Main()
        {
            const int familyTax = 50;
            const int heavyDutyTax = 80;
            const int sportsTax = 100;

            List<string> cars = Console.ReadLine().Split(">>", StringSplitOptions.RemoveEmptyEntries).ToList();

            decimal totalTaxesCollected = 0;

            for (int i = 0; i < cars.Count; i++)
            {
                string[] carCharacteristics = cars[i].Split(' ').ToArray();
                string carType = carCharacteristics[0];
                int carAge = int.Parse(carCharacteristics[1]);
                int carMileage = int.Parse(carCharacteristics[2]);

                decimal currCarTax = 0;

                if (carType == "family")
                {
                    currCarTax = familyTax;
                    currCarTax -= (carAge * 5);
                    currCarTax += ((carMileage / 3000) * 12);
                }

                else if (carType == "heavyDuty")
                {
                    currCarTax = heavyDutyTax;
                    currCarTax -= (carAge * 8);
                    currCarTax += ((carMileage / 9000) * 14);
                }

                else if (carType == "sports")
                {
                    currCarTax = sportsTax;
                    currCarTax -= (carAge * 9);
                    currCarTax += ((carMileage / 2000) * 18);
                }

                else
                {
                    Console.WriteLine("Invalid car type.");
                    continue;
                }

                Console.WriteLine($"A {carType} car will pay {currCarTax:f2} euros in taxes.");

                totalTaxesCollected += currCarTax;
            }

            Console.WriteLine($"The National Revenue Agency will collect {totalTaxesCollected:f2} euros in taxes.");
        }
    }
}
