using System;
using System.Linq;
using System.Collections.Generic;

namespace P06._Cards_Game
{
    internal class Program
    {
        static void Main()
        {
            List<int> firstPlayer = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (firstPlayer.Count != 0 && secondPlayer.Count != 0)
            {
                int firstPlayerCurrCard = firstPlayer[0];
                int secondPlayerCurrCard = secondPlayer[0];

                if (firstPlayerCurrCard > secondPlayerCurrCard)
                {
                    firstPlayer.Add(firstPlayerCurrCard);
                    firstPlayer.Add(secondPlayerCurrCard);
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }

                else if (secondPlayerCurrCard > firstPlayerCurrCard)
                {
                    secondPlayer.Add(secondPlayerCurrCard);
                    secondPlayer.Add(firstPlayerCurrCard);
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }

                else
                {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
            }

            int sumOfFirst = firstPlayer.Sum();
            int sumOfSecond = secondPlayer.Sum();

            if (sumOfFirst > sumOfSecond)
            {
                Console.WriteLine($"First player wins! Sum: {sumOfFirst}");
            }

            else
            {
                Console.WriteLine($"Second player wins! Sum: {sumOfSecond}");
            }
        }
    }
}
