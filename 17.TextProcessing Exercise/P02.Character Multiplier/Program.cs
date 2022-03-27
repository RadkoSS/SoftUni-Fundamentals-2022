using System;

namespace P02.Character_Multiplier
{
    internal class Program
    {
        static void Main()
        {
            string[] textsArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string firstText = textsArray[0];
            string secondText = textsArray[1];

            int maxLenght = Math.Max(firstText.Length, secondText.Length);
            int minLenght = Math.Min(firstText.Length, secondText.Length);

            int sumOfCharacters = 0;

            for (int i = 0; i < minLenght; i++)
            {
                sumOfCharacters += MultiplyValue(firstText[i], secondText[i]);
            }

            if (firstText.Length != secondText.Length)
            {
                string longerText = firstText.Length > secondText.Length ? firstText : secondText;

                for (int i = minLenght; i < maxLenght; i++)
                {
                    char currentSymbol = longerText[i];

                    
                    sumOfCharacters += currentSymbol; //Adds the int representation of the current symbol to the sum
                }
            }

            Console.WriteLine(sumOfCharacters);

        }

        static int MultiplyValue(char firstSymbol, char secondSymbol)
        {
            return firstSymbol * secondSymbol; // Multiplies the int representation of both chars
        }
    }
}
