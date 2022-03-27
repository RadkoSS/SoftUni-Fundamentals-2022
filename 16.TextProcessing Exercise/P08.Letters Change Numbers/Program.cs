using System;

namespace P08.Letters_Change_Numbers
{
    internal class Program
    {
        static void Main()
        {
            string[] textLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            decimal sum = 0;

            foreach (string word in textLine)
            {
                sum += CalculateStringSum(word);
            }

            Console.WriteLine($"{sum:f2}");
        }

        static decimal CalculateStringSum(string word)
        {
            char firstLetter = word[0];
            char secondLetter = word[word.Length - 1];
            decimal number = decimal.Parse(word.Substring(1, word.Length - 2));

            int firstLetterPos = LetterPositionInAlphabet(firstLetter);
            int secondLetterPos = LetterPositionInAlphabet(secondLetter);

            decimal sum = 0;

            if (char.IsUpper(firstLetter))
            {
                sum = number / firstLetterPos;

            }
            else if (char.IsLower(firstLetter))
            {
                sum = number * firstLetterPos;
            }

            if (char.IsUpper(secondLetter))
            {
                sum -= secondLetterPos;
            }
            else if (char.IsLower(secondLetter))
            {
                sum += secondLetterPos;
            }

            return sum;
        }

        static int LetterPositionInAlphabet(char letter)
        {
            if (!char.IsLetter(letter))
            {
                return -1;
            }

            char caseInsensitive = char.ToLowerInvariant(letter);

            return caseInsensitive - 96;
        }
    }
}
