using System;

namespace P11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(Operations(number, @operator, secondNumber));

        }
        static double Operations(double firstNumber, string @operator, double secondNumber)
        {
            double result = 0;
            if (@operator == "/")
            {
                result = firstNumber / secondNumber;
            }
            else if (@operator == "*")
            {
                result = firstNumber * secondNumber;
            }
            else if (@operator == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (@operator == "-")
            {
                result = firstNumber - secondNumber;
            }
            return result;
        }
    }
}
