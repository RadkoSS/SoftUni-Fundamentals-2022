﻿using System;

namespace P01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long firstNum = long.Parse(Console.ReadLine());
            long secondNum = long.Parse(Console.ReadLine());
            long thirdNum = long.Parse(Console.ReadLine());
            long fourthNum = long.Parse(Console.ReadLine());

            long sum = firstNum + secondNum;
            long division = sum / thirdNum;
            long multiplication = division * fourthNum;
            
            Console.WriteLine(multiplication);
        }
    }
}
