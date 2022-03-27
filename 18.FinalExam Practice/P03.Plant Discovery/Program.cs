using System;
using System.Linq;
using System.Collections.Generic;

namespace P03.Plant_Discovery
{
    public class PlantDiscovery
    {
        public PlantDiscovery(int rarity)
        {
            this.Rarity = rarity;
            this.Rating = new List<double>();
        }

        public int Rarity { get; set; }

        public List<double> Rating { get; set; }

    }
    internal class Program
    {
        static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Dictionary<string, PlantDiscovery> plants = new Dictionary<string, PlantDiscovery>();

            EnterNewPlants(numberOfLines, ref plants);

            ReadCommands(ref plants);

            PrintResult(plants);

        }

        static void EnterNewPlants(int numberOfLines, ref Dictionary<string, PlantDiscovery> plants)
        {
            for (int line = 0; line < numberOfLines; line++)
            {
                string[] currentPlant = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plantName = currentPlant[0];
                int rarity = int.Parse(currentPlant[1]);

                if (!plants.ContainsKey(plantName))
                {
                    PlantDiscovery newPlant = new PlantDiscovery(rarity);

                    plants.Add(plantName, newPlant);
                }

                plants[plantName].Rarity = rarity;

            }
        }

        static void ReadCommands(ref Dictionary<string, PlantDiscovery> plants)
        {
            string command;
            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] commandArguments = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string[] parameters = commandArguments[0].Split(": ", StringSplitOptions.RemoveEmptyEntries);

                if (parameters[0] == "Rate")
                {
                    string plantName = parameters[1];
                    double rating = double.Parse(commandArguments[1]);

                    if (plants.ContainsKey(plantName))
                    {
                        plants[plantName].Rating.Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                else if (parameters[0] == "Update")
                {
                    string plantName = parameters[1];
                    int rarity = int.Parse(commandArguments[1]);

                    if (plants.ContainsKey(plantName))
                    {
                        plants[plantName].Rarity = rarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                else if (parameters[0] == "Reset")
                {
                    string plantName = parameters[1];

                    if (plants.ContainsKey(plantName))
                    {
                        plants[plantName].Rating.Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }
        }

        static void PrintResult(Dictionary<string, PlantDiscovery> plants)
        {
            Console.WriteLine("Plants for the exhibition:");

            foreach (KeyValuePair<string, PlantDiscovery> plant in plants)
            {
                double currentAvgRating = plant.Value.Rating.Count > 0 ? plant.Value.Rating.Average() : 0;

                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {currentAvgRating:f2}");
            }
        }
    }
}
