using System;
using System.Collections.Generic;

namespace P06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            List<Vehicle> cars = new List<Vehicle>();
            List<Vehicle> trucks = new List<Vehicle>();

            string vehicleCharacteristics = string.Empty;
            while ((vehicleCharacteristics = Console.ReadLine()) != "End")
            {
                string[] currentVehicle = vehicleCharacteristics.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string vehicleType = currentVehicle[0].ToLower();
                string vehicleModel = currentVehicle[1];
                string vehicleColor = currentVehicle[2].ToLower();
                int horsePower = int.Parse(currentVehicle[3]);

                Vehicle vehicle = new Vehicle(vehicleType, vehicleModel, vehicleColor, horsePower);
                vehicles.Add(vehicle);

                if (vehicleType == "car")
                {
                    cars.Add(vehicle);
                }

                else if (vehicleType == "truck")
                {
                    trucks.Add(vehicle);
                }
            }

            string model = string.Empty;

            while ((model = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(vehicles.Find(vehicle => vehicle.Model == model));
            }

            double carsHp = 0;
            foreach (var car in cars)
            {
                double currCarHp = car.HorsePower;
                carsHp += currCarHp;
            }

            carsHp /= cars.Count;

            double trucksHp = 0;
            foreach (var truck in trucks)
            {
                double truckHp = truck.HorsePower;
                trucksHp += truckHp;
            }

            trucksHp /= trucks.Count;

            if (cars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {carsHp:f2}.");
            }

            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {trucksHp:f2}.");
            }

            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }

        public override string ToString()
        {
            return $"Type: {(this.Type == "car" ? "Car" : "Truck")}" +
                $"{Environment.NewLine}Model: {this.Model}" +
                $"{Environment.NewLine}Color: {this.Color}" +
                $"{Environment.NewLine}Horsepower: {this.HorsePower}";
        }
    }
}
