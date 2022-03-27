using System;

namespace P01._Randomize_Words
{
    internal class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Random rnd = new Random();

            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                int pos2 = rnd.Next(0, words.Length - 1);
                words[pos1] = words[pos2];
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));

        }
    }
}
