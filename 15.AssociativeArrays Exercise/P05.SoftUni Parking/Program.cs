using System;
using System.Linq;
using System.Collections.Generic;

namespace P05.SoftUni_Parking
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, string> parkingRegister = new Dictionary<string, string>();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfCommands; i++)
            {
                string[] cmdArguments = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string commandType = cmdArguments[0];
                string username = cmdArguments[1];

                if (commandType == "register")
                {
                    string licensePlateNumber = cmdArguments[2];

                    RegisterUsers(parkingRegister, username, licensePlateNumber);
                }

                else if (commandType == "unregister")
                {
                    UnregisterUsers(parkingRegister, username);
                }
            }

            PrintAllUsers(parkingRegister);
        }
        static void RegisterUsers(Dictionary<string, string> parkingRegister, string username, string licensePlateNumber)
        {
            if (!parkingRegister.TryAdd(username, licensePlateNumber))
            {
                Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
            }
            else
            {
                Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
            }
        }

        static void UnregisterUsers(Dictionary<string, string> parkingRegister, string username)
        {
            if (!parkingRegister.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: user {username} not found");
            }
            else
            {
                parkingRegister.Remove(username);
                Console.WriteLine($"{username} unregistered successfully");
            }
        }

        static void PrintAllUsers(Dictionary<string, string> parkingRegister)
        {
            foreach (KeyValuePair<string, string> user in parkingRegister)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
