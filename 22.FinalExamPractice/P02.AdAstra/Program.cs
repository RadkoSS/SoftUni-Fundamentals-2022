using System;
using System.Text;
using System.Text.RegularExpressions;

namespace P02.AdAstra
{
    internal class Program
    {
        static void Main()
        {
            const int NutritionPerDay = 2000;

            Regex regex = new Regex(@"(\||\#)(?<item>[A-Z a-z]+)(\1)(?<expDate>\d{2}\/\d{2}\/\d{2})(\1)(?<calories>\d{1,5})(\1)");

            string text = Console.ReadLine();

            MatchCollection products = regex.Matches(text);

            StringBuilder productsToPrint = new StringBuilder();

            int totalCallories = 0;

            foreach (Match product in products)
            {
                string productName = product.Groups["item"].Value;
                string expirationDate = product.Groups["expDate"].Value;
                int productCallories = int.Parse(product.Groups["calories"].Value);

                totalCallories += productCallories;

                productsToPrint.AppendLine($"Item: {productName}, Best before: {expirationDate}, Nutrition: {productCallories}");
            }

            Console.WriteLine($"You have food to last you for: {totalCallories / NutritionPerDay} days!");

            Console.WriteLine(productsToPrint);
        }
    }
}
