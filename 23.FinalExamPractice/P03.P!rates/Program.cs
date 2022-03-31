using System;
using System.Linq;
using System.Collections.Generic;

namespace P03.P_rates
{
    public class City
    {
        public City(string cityName, int population, int gold)
        {
            Name = cityName;
            Population = population;
            Gold = gold;
        }

        public string Name { get; set; }

        public int Population { get; set; }

        public int Gold { get; set; }

        public override string ToString()
        {
            return $"{Name} -> Population: {Population} citizens, Gold: {Gold} kg";
        }
    }
    internal class Program
    {
        static void Main()
        {
            List<City> citiesList = new List<City>();

            InitializeCities(citiesList);

            PrintCitiesLeftToPlunder(citiesList);
        }

        static List<City> InitializeCities(List<City> citiesList)
        {
            string cityName = string.Empty;
            while ((cityName = Console.ReadLine()) != "Sail")
            {
                string[] cityInfo = cityName.Split("||", StringSplitOptions.RemoveEmptyEntries);

                if (citiesList.Any(city => city.Name == cityInfo[0]))
                {
                    citiesList.Find(city => city.Name == cityInfo[0]).Name = cityInfo[0];

                    citiesList.Find(city => city.Name == cityInfo[0]).Population += int.Parse(cityInfo[1]);

                    citiesList.Find(city => city.Name == cityInfo[0]).Gold += int.Parse(cityInfo[2]);
                }
                else
                {
                    citiesList.Add(new City(cityInfo[0], int.Parse(cityInfo[1]), int.Parse(cityInfo[2])));
                }
            }
            ExecuteOrders(citiesList);

            return citiesList;
        }

        static void ExecuteOrders(List<City> citiesList)
        {
            string order = string.Empty;
            while ((order = Console.ReadLine()) != "End")
            {
                string[] orderInfo = order.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string cityName = orderInfo[1];
                if (orderInfo[0] == "Plunder")
                {
                    int peopleKilled = int.Parse(orderInfo[2]);
                    int goldStolen = int.Parse(orderInfo[3]);

                    citiesList.Find(city => city.Name == cityName).Population -= peopleKilled;

                    citiesList.Find(city => city.Name == cityName).Gold -= goldStolen;

                    Console.WriteLine($"{cityName} plundered! {goldStolen} gold stolen, {peopleKilled} citizens killed.");

                    if (citiesList.Find(city => city.Name == cityName).Gold == 0 || citiesList.Find(city => city.Name == cityName).Population == 0)
                    {
                        citiesList.RemoveAll(city => city.Name == cityName);

                        Console.WriteLine($"{cityName} has been wiped off the map!");
                    }
                }

                else if (orderInfo[0] == "Prosper")
                {
                    int goldToAdd = int.Parse(orderInfo[2]);

                    if (goldToAdd < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else
                    {
                        citiesList.Find(city => city.Name == cityName).Gold += goldToAdd;

                        Console.WriteLine($"{goldToAdd} gold added to the city treasury. {cityName} now has {citiesList.Find(city => city.Name == cityName).Gold} gold.");
                    }
                }
            }
        }

        static void PrintCitiesLeftToPlunder(List<City> citiesList)
        {
            if (citiesList.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {citiesList.Count} wealthy settlements to go to:");
                Console.WriteLine(string.Join(Environment.NewLine, citiesList));
            }
        }
    }
}
