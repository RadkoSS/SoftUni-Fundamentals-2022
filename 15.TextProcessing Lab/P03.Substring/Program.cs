using System;
using System.Text;

namespace P03.Substring
{
    internal class Program
    {
        static void Main()
        {
            string bannedWord = Console.ReadLine();
            string words = Console.ReadLine();

            while (words.Contains(bannedWord))
            {
                int index = words.IndexOf(bannedWord);
                words = words.Remove(index, bannedWord.Length);
            }
            Console.WriteLine(words);
        }
    }
}
