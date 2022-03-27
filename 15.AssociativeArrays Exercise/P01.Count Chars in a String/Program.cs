using System;
using System.Collections.Generic;

namespace P01.Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            foreach (string item in text)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    char currentChar = item[i];

                    if (dictionary.ContainsKey(currentChar))
                    {
                        dictionary[currentChar] += 1;
                    }
                    else
                    {
                        dictionary.Add(currentChar, 1);
                    }
                }
            }

            foreach (KeyValuePair<char, int> pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
