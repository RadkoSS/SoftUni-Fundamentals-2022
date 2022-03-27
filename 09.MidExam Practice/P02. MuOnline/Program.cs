using System;
using System.Linq;
using System.Collections.Generic;

namespace P02._MuOnline
{
    internal class Program
    {
        static void Main()
        {
            List<string> rooms = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
            int healthBar = 100;
            int totalBtc = 0;
            bool gameOverPremature = false;

            for (int i = 0; i < rooms.Count; i++)
            {

                string[] cmdArguments = rooms[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArguments[0];

                if (cmdType == "potion")
                {
                    int hp = int.Parse(cmdArguments[1]);
                    int hpRestored = hp + healthBar;
                    if (hpRestored >= 100)
                    {
                        healthBar = 100;
                        int hpHealed = Math.Abs(hpRestored - hp - healthBar);
                        Console.WriteLine($"You healed for {hpHealed} hp.");
                    }
                    else
                    {
                        healthBar = hpRestored;
                        Console.WriteLine($"You healed for {hp} hp.");
                    }
                    Console.WriteLine($"Current health: {healthBar} hp.");
                }

                else if (cmdType == "chest")
                {
                    int btcFound = int.Parse(cmdArguments[1]);
                    totalBtc += btcFound;
                    Console.WriteLine($"You found {btcFound} bitcoins.");
                }

                else
                {
                    int monsterAttack = int.Parse(cmdArguments[1]);
                    healthBar -= monsterAttack;
                    if (healthBar <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {cmdType}.");
                        Console.WriteLine($"Best room: {++i}");
                        gameOverPremature = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {cmdType}.");
                    }
                }
            }

            if (!gameOverPremature)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {totalBtc}");
                Console.WriteLine($"Health: {healthBar}");
            }
        }
    }
}
