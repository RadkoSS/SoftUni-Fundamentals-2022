using System;
using System.Collections.Generic;

namespace P03.Heroes_of_Code_and_Logic_VII
{
    public class Hero 
    {
        public Hero(string name, int hitPoints, int manaPoints)
        {
            this.Name = name;
            this.HitPoints = hitPoints;
            this.ManaPoints = manaPoints;
        }

        public string Name { get; set; }

        public int HitPoints { get; set; }

        public int ManaPoints { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            int heroesCount = int.Parse(Console.ReadLine());

            List<Hero> heroesList = new List<Hero>();

            heroesList = InitializeHeroes(heroesList, heroesCount);

            PrintAliveHeroes(heroesList);
        }

        static List<Hero> InitializeHeroes(List<Hero> heroesList, int heroesCount)
        {
            for (int i = 0; i < heroesCount; i++)
            {
                string[] heroInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Hero newHero = new Hero(heroInfo[0], int.Parse(heroInfo[1]), int.Parse(heroInfo[2]));

                heroesList.Add(newHero);
            }

            heroesList = PerformActions(heroesList);

            return heroesList;
        }

        static List<Hero> PerformActions(List<Hero> heroesList)
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string commandType = commandArgs[0];

                string heroName = commandArgs[1];

                if (commandType == "CastSpell")
                {
                    int manaPointsNeeded = int.Parse(commandArgs[2]);
                    string spell = commandArgs[3];
                    int currentHeroMana = heroesList.Find(hero => hero.Name == heroName).ManaPoints;

                    if (currentHeroMana < manaPointsNeeded)
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spell}!");
                    }
                    else
                    {
                        int manaLeft = currentHeroMana - manaPointsNeeded;

                        heroesList.Find(hero => hero.Name == heroName).ManaPoints = manaLeft;

                        Console.WriteLine($"{heroName} has successfully cast {spell} and now has {manaLeft} MP!");
                    }
                }

                else if (commandType == "TakeDamage")
                {
                    int damageTaken = int.Parse(commandArgs[2]);
                    string attacker = commandArgs[3];
                    int currentHeroHP = heroesList.Find(hero => hero.Name == heroName).HitPoints;

                    int hpLeft = currentHeroHP - damageTaken;

                    if (hpLeft <= 0)
                    {
                        heroesList.RemoveAll(hero => hero.Name == heroName);

                        Console.WriteLine($"{heroName} has been killed by {attacker}!");

                    }
                    else
                    {
                        heroesList.Find(hero => hero.Name == heroName).HitPoints = hpLeft;

                        Console.WriteLine($"{heroName} was hit for {damageTaken} HP by {attacker} and now has {hpLeft} HP left!");
                    }
                }

                else if (commandType == "Recharge")
                {
                    int rechargeManaPoints = int.Parse(commandArgs[2]);
                    int currentHeroMana = heroesList.Find(hero => hero.Name == heroName).ManaPoints;

                    int rechargedPts = currentHeroMana + rechargeManaPoints;

                    if (rechargedPts > 200)
                    {
                        rechargedPts = 200;
                        int exactAmountRecharged = 200 - currentHeroMana;

                        Console.WriteLine($"{heroName} recharged for {exactAmountRecharged} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} recharged for {rechargeManaPoints} MP!");
                    }

                    heroesList.Find(hero => hero.Name == heroName).ManaPoints = rechargedPts;
                }

                else if (commandType == "Heal")
                {
                    int healPoints = int.Parse(commandArgs[2]);
                    int currentHeroHP = heroesList.Find(hero => hero.Name == heroName).HitPoints;

                    int rechargedPts = currentHeroHP + healPoints;

                    if (rechargedPts > 100)
                    {
                        rechargedPts = 100;
                        int exactAmountHealed = 100 - currentHeroHP;

                        Console.WriteLine($"{heroName} healed for {exactAmountHealed} HP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} healed for {healPoints} HP!");
                    }

                    heroesList.Find(hero => hero.Name == heroName).HitPoints = rechargedPts;
                }
            }
            return heroesList;
        }

        static void PrintAliveHeroes(List<Hero> heroesList)
        {
            foreach (Hero hero in heroesList)
            {
                Console.WriteLine(hero.Name);

                Console.WriteLine($"  HP: {hero.HitPoints}");

                Console.WriteLine($"  MP: {hero.ManaPoints}");
            }
        }
    }
}