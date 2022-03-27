using System;
using System.Text;

namespace P04.Caesar_Cipher
{
    internal class Program
    {
        static void Main()
        {
            char[] textLine = Console.ReadLine().ToCharArray();

            StringBuilder caesarCipher = new StringBuilder();

            foreach (char symbol in textLine)
            {
                caesarCipher.Append(ReturnEncrypted(symbol));
            }

            Console.WriteLine(caesarCipher.ToString().Trim());
        }

        static char ReturnEncrypted(char symbol)
        {
            int newChar = (int)symbol + 3;

            return (char)newChar;
        }
    }
}
