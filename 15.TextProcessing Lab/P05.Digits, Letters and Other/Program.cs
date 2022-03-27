using System;
using System.Linq;
using System.Text;

namespace P05.Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder chars = new StringBuilder();

            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    letters.Append(text[i]);
                }

                else if (char.IsDigit(text[i]))
                {
                    digits.Append(text[i]);
                }

                else
                {
                    chars.Append(text[i]);
                }
            }

            Console.WriteLine(digits.ToString());
            Console.WriteLine(letters.ToString());
            Console.WriteLine(chars.ToString());
        }
    }
}
