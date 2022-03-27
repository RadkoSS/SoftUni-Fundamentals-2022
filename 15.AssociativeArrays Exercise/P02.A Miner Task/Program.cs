using System;
using System.Collections.Generic;

namespace P02.A_Miner_Task
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, long> materialsDictionary = new Dictionary<string, long>();

            ReadMaterials(materialsDictionary);

            PrintResult(materialsDictionary);

        }

        static void ReadMaterials(Dictionary<string, long> materialsDictionary)
        {
            string material = string.Empty;

            while ((material = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!materialsDictionary.ContainsKey(material))
                {
                    materialsDictionary.Add(material, 0);
                }

                materialsDictionary[material] += quantity;
            }
        }

        static void PrintResult(Dictionary<string, long> materialsDictionary)
        {
            foreach (KeyValuePair<string, long> currMaterial in materialsDictionary)
            {
                Console.WriteLine($"{currMaterial.Key} -> {currMaterial.Value}");
            }
        }
    }
}
