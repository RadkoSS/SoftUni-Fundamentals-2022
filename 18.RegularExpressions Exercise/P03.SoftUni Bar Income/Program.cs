using System;
using System.Text.RegularExpressions;

namespace P03.SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main()
        {
            string pattern = @"\%(?<name>[A-Z]{1}[a-z]+)\%[^\|\$\%\.]*?\<(?<product>\w+)\>[^\|\$\%\.]*?\|(?<quantity>\d+)\|[^\|\$\%\.]*?(?<price>\d+(.\d+)*?)\$";

            decimal totalIncome = 0m; // :f2
            string textLine;
            while ((textLine = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(textLine, pattern);
                if (match.Success)
                {
                    string customerName = match.Groups["name"].Value;
                    string productName = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    decimal productPrice = decimal.Parse(match.Groups["price"].Value);

                    totalIncome += quantity * productPrice;

                    Console.WriteLine($"{customerName}: {productName} - {quantity * productPrice:f2}");
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
