﻿using System;

namespace P05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startPoint = int.Parse(Console.ReadLine());
            int endPoint = int.Parse(Console.ReadLine());

            for (int currSymbol = startPoint; currSymbol <= endPoint; currSymbol++)
            {
                Console.Write($"{(char)currSymbol} ");
            }
        }
    }
}
