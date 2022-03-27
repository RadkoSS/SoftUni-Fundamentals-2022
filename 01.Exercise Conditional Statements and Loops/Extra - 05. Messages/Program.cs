using System;
using System.Text;

namespace Extra___05._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int buttonClicks = int.Parse(Console.ReadLine());
            string message = string.Empty;
            for (int i = 0; i < buttonClicks; i++)
            {
                string currNum = Console.ReadLine();
                int lenght = currNum.Length;
                int mainDigit = currNum[0] - '0';
                int offset = (mainDigit - 2) * 3;
                if (mainDigit == 0)
                {
                    message += (char)(mainDigit + 32); // adds a space
                    continue;
                }
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }
                int letterIndex = offset + lenght - 1;
                message += (char)(letterIndex + 97);
            }
            Console.WriteLine(message);
        }
    }
}