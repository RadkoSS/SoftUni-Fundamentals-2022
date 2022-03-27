using System;
using System.Text;

namespace P07.String_Explosion
{
    internal class Program
    {
        static void Main()
        {
            string textLine = Console.ReadLine();

            StringBuilder finalResult = new StringBuilder();

            int bombPower = 0;

            for (int index = 0; index < textLine.Length; index++)
            {
                char currentCharacter = textLine[index];

                if (currentCharacter == '>')
                {
                    int currentBombPower = ReturnInteger(textLine[index + 1]);

                    bombPower += currentBombPower;

                    finalResult.Append(currentCharacter);
                }

                else
                {
                    if (bombPower > 0)
                    {
                        bombPower--;
                    }

                    else
                    {
                        finalResult.Append(currentCharacter);
                    }
                }
            }

            Console.WriteLine(finalResult.ToString().Trim());
        }

        static int ReturnInteger(char character)
        {
            return (int)character - '0';
        }
    }
}
