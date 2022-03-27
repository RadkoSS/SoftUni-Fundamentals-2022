using System;
using System.Linq;
using System.Collections.Generic;

namespace P06.Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main()
        {
            List<char> text = Console.ReadLine().ToList();

            for (int index = 0; index < text.Count - 1; index++)
            {
                char currentSymbol = text[index];
                char nextSymbol = text[index + 1];

                if (currentSymbol == nextSymbol)
                {
                    text.RemoveAt(index);
                    index--;
                }
            }

            Console.WriteLine(string.Join(string.Empty, text));
        }
    }
}
