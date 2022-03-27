using System;
using System.Linq;
using System.Collections.Generic;

namespace P03.Legendary_Farming
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>()
            {
                ["shards"] = 0,
                ["motes"] = 0,
                ["fragments"] = 0
            };

            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            string legendaryItemFound = string.Empty;

            while (String.IsNullOrEmpty(legendaryItemFound))
            {
                string[] foundMaterials = Console.ReadLine().ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                legendaryItemFound = IterateThroughInput(keyMaterials, junkMaterials, foundMaterials, legendaryItemFound);
            }

            Print(keyMaterials, junkMaterials, legendaryItemFound);

        }
        static string IterateThroughInput(Dictionary<string, int> keyMaterials, Dictionary<string, int> junkMaterials, string[] foundMaterials, string legendaryItem)
        {
            const int materialsNeededToCraft = 250;

            for (int i = 0; i < foundMaterials.Length; i += 2)
            {
                int quantity = int.Parse(foundMaterials[i]);
                string materialName = foundMaterials[i + 1];

                if (keyMaterials.ContainsKey(materialName))
                {
                    keyMaterials[materialName] += quantity;
                }

                else
                {
                    if (junkMaterials.ContainsKey(materialName))
                    {
                        junkMaterials[materialName] += quantity;
                    }
                    else
                    {
                        junkMaterials.Add(materialName, quantity);
                    }
                }

                if (keyMaterials.Any(material => material.Value >= materialsNeededToCraft))
                {
                    break;
                }
            }

            if (keyMaterials["shards"] >= materialsNeededToCraft)
            {
                legendaryItem = "Shadowmourne";
                keyMaterials["shards"] -= materialsNeededToCraft;
            }
            else if (keyMaterials["fragments"] >= materialsNeededToCraft)
            {
                legendaryItem = "Valanyr";
                keyMaterials["fragments"] -= materialsNeededToCraft;
            }
            else if (keyMaterials["motes"] >= materialsNeededToCraft)
            {
                legendaryItem = "Dragonwrath";
                keyMaterials["motes"] -= materialsNeededToCraft;
            }

            return legendaryItem;
        }
        static void Print(Dictionary<string, int> keyMaterials, Dictionary<string, int> junkMaterials, string legendaryItem)
        {
            Console.WriteLine($"{legendaryItem} obtained!");

            foreach (KeyValuePair<string, int> item in keyMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (KeyValuePair<string, int> item in junkMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
