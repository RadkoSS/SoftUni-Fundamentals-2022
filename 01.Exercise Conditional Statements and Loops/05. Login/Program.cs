using System;
using System.Text;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            string password = String.Empty;
            StringBuilder sb = new StringBuilder();
            for (int reverse = username.Length - 1; reverse >= 0; reverse--)
            {
                sb.Append(username[reverse]);
                password = sb.ToString();
            }
            for (int i = 1; i <= 4; i++)
            {
                string currentPassword = Console.ReadLine();
                if (currentPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (i == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}