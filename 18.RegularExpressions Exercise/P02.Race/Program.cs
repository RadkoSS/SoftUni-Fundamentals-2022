using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace P02.Race
{
    internal class Program
    {
        static void Main()
        {

            string[] names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> racers = new Dictionary<string, int>();

            foreach (string name in names)
            {
                racers.Add(name, 0);
            }

            string line;
            while ((line = Console.ReadLine()) != "end of race")
            {
                string currentRacerName = ReturnName(line);
                int distance = ReturnRacerScore(line);

                if (racers.ContainsKey(currentRacerName))
                {
                    racers[currentRacerName] += distance;
                }

            }

            PrintWinners(racers);
        }

        static string ReturnName(string line)
        {
            StringBuilder name = new StringBuilder();

            foreach (char ch in line)
            {
                if (char.IsLetter(ch))
                {
                    name.Append(ch);
                }
            }
            return name.ToString();
        }

        static int ReturnRacerScore(string line)
        {
            int score = 0;

            foreach (char ch in line)
            {
                if (char.IsDigit(ch)) 
                {
                    score += (ch - '0');
                }
            }
            return score;
        }

        static void PrintWinners(Dictionary<string, int> racers)
        {
            List<string> winners = new List<string>();

            int place = 0;

            foreach (KeyValuePair<string, int> racer in racers.OrderByDescending(racer => racer.Value))
            {
                winners.Add(racer.Key);
                place++;
                if (place == 3)
                {
                    break;
                }
            }

            Console.WriteLine($"1st place: {winners[0]}");
            Console.WriteLine($"2nd place: {winners[1]}");
            Console.WriteLine($"3rd place: {winners[2]}");
        }
    }
}
