using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double priceForOneMan = 0;

            switch (day)
            {
                case "Friday":
                    if (groupType == "Students")
                    {
                        priceForOneMan = 8.45;
                    }
                    else if (groupType == "Business")
                    {
                        priceForOneMan = 10.9;
                    }
                    else if (groupType == "Regular")
                    {
                        priceForOneMan = 15;
                    }
                    break;
                case "Saturday":
                    if (groupType == "Students")
                    {
                        priceForOneMan = 9.8;
                    }
                    else if (groupType == "Business")
                    {
                        priceForOneMan = 15.6;
                    }
                    else if (groupType == "Regular")
                    {
                        priceForOneMan = 20;
                    }
                    break;
                case "Sunday":
                    if (groupType == "Students")
                    {
                        priceForOneMan = 10.46;
                    }
                    else if (groupType == "Business")
                    {
                        priceForOneMan = 16;
                    }
                    else if (groupType == "Regular")
                    {
                        priceForOneMan = 22.5;
                    }
                    break;
            }
            double price = countOfPeople * priceForOneMan;
            if (groupType == "Students" && countOfPeople >= 30)
            {
                price *= 0.85;
            }
            else if (groupType == "Business" && countOfPeople >= 100)
            {
                price -= priceForOneMan * 10;
            }
            else if (groupType == "Regular" && (countOfPeople > 10 && countOfPeople < 20))
            {
                price *= 0.95;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
