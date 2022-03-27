using System;
using System.Linq;
using System.Collections.Generic;

namespace P01._Train
{
    internal class Program
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                
                string cmdType = tokens[0];
                if (cmdType == "Add")
                {
                    int passengersToAdd = int.Parse(tokens[1]);
                    wagons.Add(passengersToAdd);
                }
                else
                {
                    int passengersToAdd = int.Parse((tokens[0]));
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currentWagon = wagons[i] + passengersToAdd;
                        if (currentWagon <= maxCapacity)
                        {
                            wagons[i] += passengersToAdd;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
