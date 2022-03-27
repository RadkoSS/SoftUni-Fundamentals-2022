using System;

namespace P01._Burger_Bus
{
    internal class Program
    {
        static void Main()
        {
            int cities = int.Parse(Console.ReadLine());
            decimal totalProfit = 0;

            for (int i = 1; i <= cities; i++)
            {
                string currentCity = Console.ReadLine();

                decimal income = decimal.Parse(Console.ReadLine());
                decimal expenses = decimal.Parse(Console.ReadLine());

                if (i % 5 == 0)
                {
                    income *= 0.9m;
                }
                else if (i % 3 == 0)
                {
                    expenses *= 1.5m;
                }
                
                decimal profit = income - expenses;
                totalProfit += profit;

                Console.WriteLine($"In {currentCity} Burger Bus earned {profit:f2} leva.");
            }

            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }
    }
}
