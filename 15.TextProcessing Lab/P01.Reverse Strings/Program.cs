using System;
using System.Text;

namespace P01.Reverse_Strings
{
    internal class Program
    {
        static void Main()
        {
            string currentWord = string.Empty;
            StringBuilder stringBuilder = new StringBuilder();

            while ((currentWord = Console.ReadLine())!= "end")
            {
                string reversed = string.Empty;

                for (int i = currentWord.Length - 1; i >= 0; i--)
                {
                    reversed = stringBuilder.Append(currentWord[i]).ToString();
                }
                 
                Console.WriteLine($"{currentWord} = {reversed}");
                stringBuilder.Clear();
            }

        }
    }
}
