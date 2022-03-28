using System;
using System.Text;
using System.Text.RegularExpressions;

namespace P02.FancyBarcodes
{
    internal class Program
    {
        static void Main()
        {
            int numberOfBarcodes = int.Parse(Console.ReadLine());

            Regex regex = new Regex(@"\@\#{1,}(?<barcode>[A-Z][a-zA-Z0-9]{4,}[A-Z])\@\#{1,}");

            for (int i = 0; i < numberOfBarcodes; i++)
            {
                string currentBarcode = Console.ReadLine();

                Match match = regex.Match(currentBarcode);

                if (match.Success)
                {
                    string group = ReturnGroup(match.Groups["barcode"].Value);

                    Console.WriteLine($"Product group: {group}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }

        static string ReturnGroup(string barcode)
        {
            StringBuilder group = new StringBuilder();

            foreach (char ch in barcode)
            {
                if (char.IsDigit(ch))
                {
                    group.Append(ch);
                }
            }

            if (group.Length == 0)
            {
                return "00";
            }

            return group.ToString();
        }
    }
}
