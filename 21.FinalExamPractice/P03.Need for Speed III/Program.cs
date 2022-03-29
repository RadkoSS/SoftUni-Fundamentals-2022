using System;
using System.Collections.Generic;

namespace P03.Need_for_Speed_III
{
    public class Car 
    {
        public Car(string model, int mileage, int fuel)
        {
            this.Model = model;
            this.Mileage = mileage;
            this.Fuel = fuel;
        }

        public string Model { get; set; }

        public int Mileage { get; set; }

        public int Fuel { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            int carsCount = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            cars = InitializeCars(carsCount, cars);

            PrintResult(cars);
        }

        static List<Car> InitializeCars(int carsCount, List<Car> carsList)
        {
            for (int i = 1; i <= carsCount; i++)
            {
                string[] carInfo = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];
                int mileage = int.Parse(carInfo[1]);
                int fuel = int.Parse(carInfo[2]);

                Car car = new Car(model, mileage, fuel);

                carsList.Add(car);
            }

            ApllyCommands(carsList);

            return carsList;
        }
        static List<Car> ApllyCommands(List<Car> carsList)
        {
            const int MaxCarMileage = 100000;
            const int MaxFuelTankCapacity = 75;

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] commandAgs = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string commandType = commandAgs[0];
                string carName = commandAgs[1];

                if (commandType == "Drive")
                {
                    int distance = int.Parse(commandAgs[2]);
                    int fuelNeeded = int.Parse((commandAgs[3]));

                    int currentCarFuel = carsList.Find(car => car.Model == carName).Fuel;

                    if (currentCarFuel < fuelNeeded)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        carsList.Find(car => car.Model == carName).Mileage += distance;

                        carsList.Find(car => car.Model == carName).Fuel -= fuelNeeded;

                        Console.WriteLine($"{carName} driven for {distance} kilometers. {fuelNeeded} liters of fuel consumed.");

                        int currentCarMileage = carsList.Find(car => car.Model == carName).Mileage;

                        if (currentCarMileage >= MaxCarMileage)
                        {
                            carsList.RemoveAll(car => car.Model == carName);

                            Console.WriteLine($"Time to sell the {carName}!");
                        }
                    }
                }

                else if (commandType == "Refuel")
                {
                    int fuelToRefill = int.Parse(commandAgs[2]);

                    int currentCarFuel = carsList.Find(car => car.Model == carName).Fuel;

                    int refilledFuelAmount = fuelToRefill + currentCarFuel;

                    if (refilledFuelAmount > MaxFuelTankCapacity)
                    {
                        int exactFuelAmount = MaxFuelTankCapacity - currentCarFuel;

                        Console.WriteLine($"{carName} refueled with {exactFuelAmount} liters");

                        carsList.Find(car => car.Model == carName).Fuel = MaxFuelTankCapacity;
                    }
                    else
                    {
                        Console.WriteLine($"{carName} refueled with {fuelToRefill} liters");

                        carsList.Find(car => car.Model == carName).Fuel += fuelToRefill;
                    }
                }

                else if (commandType == "Revert")
                {
                    int mileageToRevert = int.Parse(commandAgs[2]);

                    int currentCarMileage = carsList.Find(car => car.Model == carName).Mileage;

                    int reducedMileage = currentCarMileage - mileageToRevert;
                    if (reducedMileage < 10000)
                    {
                        carsList.Find(car => car.Model == carName).Mileage = 10000;
                    }
                    else
                    {
                        carsList.Find(car => car.Model == carName).Mileage -= mileageToRevert;

                        Console.WriteLine($"{carName} mileage decreased by {mileageToRevert} kilometers");
                    }
                }
            }

            return carsList;
        }

        static void PrintResult(List<Car> carsList)
        {
            foreach (Car car in carsList)
            {
                Console.WriteLine($"{car.Model} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }
    }
}