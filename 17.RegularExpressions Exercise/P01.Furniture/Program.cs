using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P01.Furniture
{
    internal class Program
    {
        static void Main()
        {
            string regex = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";
            //@">>(?<name>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quant>\d+)";

            List<string> furnitureNames = new List<string>();

            double totalMoney = 0;

            string inputLine = string.Empty;
            while ((inputLine = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(inputLine, regex);

                if (match.Success)
                {
                    string productName = match.Groups["name"].Value;
                    double productPrice = double.Parse(match.Groups["price"].Value);
                    int productQuantity = int.Parse(match.Groups["quantity"].Value);

                    furnitureNames.Add(productName);

                    totalMoney += productPrice * productQuantity;
                }
            }

            Console.WriteLine("Bought furniture:");

            if (furnitureNames.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, furnitureNames));
            }

            Console.WriteLine($"Total money spend: {totalMoney:f2}");

        }
    }
}
