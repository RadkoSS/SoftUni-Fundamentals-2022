using System;
using System.Collections.Generic;

namespace P04.Orders
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int> productsWithCount = new Dictionary<string, int>();

            Dictionary<string, double> productsWithPrice = new Dictionary<string, double>();

            string command;

            while ((command = Console.ReadLine()) != "buy")
            {
                string[] cmdArguments = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string productName = cmdArguments[0];
                double price = double.Parse(cmdArguments[1]);
                int quantity = int.Parse(cmdArguments[2]);

                if (productsWithCount.ContainsKey(productName))
                {
                    productsWithCount[productName] += quantity;
                }
                else
                {
                    productsWithCount.Add(productName, quantity);
                }

                if (productsWithPrice.ContainsKey(productName))
                {
                    productsWithPrice[productName] = price;
                }
                else
                {
                    productsWithPrice.Add(productName, price);
                }
            }

            foreach (KeyValuePair<string, int> product in productsWithCount)
            {
                string productName = product.Key;
                int quantity = product.Value;
                double price = productsWithPrice[productName];

                double totalPrice = price * quantity;

                Console.WriteLine($"{productName} -> {totalPrice:f2}");
            }
        }
    }
}
