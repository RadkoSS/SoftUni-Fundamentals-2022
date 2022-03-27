using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02.Destination_Mapper
{
    internal class Program
    {
        static void Main()
        {
            string places = Console.ReadLine();

            Regex regex = new Regex(@"(\=|\/)(?<location>[A-Z][A-Za-z]{2,})(\1)");

            List<string> locations = new List<string>();

            int points = 0;

            foreach (Match match in regex.Matches(places))
            {
                string locationName = match.Groups["location"].Value;

                locations.Add(locationName);

                points += GetLenght(locationName);
            }

            if (locations.Count > 0)
            {
                Console.WriteLine($"Destinations: {string.Join(", ", locations)}");
                Console.WriteLine($"Travel Points: {points}");
            }
            else
            {
                Console.WriteLine("Destinations:");
                Console.WriteLine($"Travel Points: {points}");
            }

        }
        static int GetLenght(string location)
        {
            return location.Length;
        }
    }
}
