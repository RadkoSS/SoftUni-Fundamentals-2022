using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double orderPrice = 0;
            double price = 0;
            for (int i = 1; i <= n; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                double capsulesCount = double.Parse(Console.ReadLine());
                orderPrice = (days * capsulesCount) * capsulePrice;
                price += orderPrice;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
                orderPrice = 0;
            }
            Console.WriteLine($"Total: ${price:f2}");
        }
    }
}