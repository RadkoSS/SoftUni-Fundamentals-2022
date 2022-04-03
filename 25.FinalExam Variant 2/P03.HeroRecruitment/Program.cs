using System;
using System.Linq;
using System.Collections.Generic;

namespace P03.HeroRecruitment
{
    public class Hero
    {
        public Hero(string name)
        {
            Name = name;
            SpellNames = new List<string>();
        }

        public string Name { get; set; }

        public List<string> SpellNames { get; set; }

        public void AddSpell(string spellName)
        {
            if (SpellNames.Contains(spellName))
            {
                Console.WriteLine($"{Name} has already learnt {spellName}.");
            }
            else
            {
                SpellNames.Add(spellName);
            }
        }

        public void RemoveSpell(string heroName, string spellName)
        {
            if (SpellNames.Contains(spellName))
            {
                if (heroName == Name)
                {
                    SpellNames.Remove(spellName);
                }
                else
                {
                    Console.WriteLine($"{heroName} doesn't exist.");
                }
            }
            else
            {
                Console.WriteLine($"{Name} doesn't know {spellName}.");
            }
        }

        public override string ToString()
        {
            return $"== {Name}: {string.Join(", ", SpellNames)}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            List<Hero> heroesList = new List<Hero>();
            ExecuteCommands(heroesList);
        }

        static void ExecuteCommands(List<Hero> heroesList)
        {
            string line = string.Empty;
            while ((line = Console.ReadLine()) != "End")
            {
                string[] heroInfo = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string heroName = heroInfo[1];

                if (heroInfo[0] == "Enroll")
                {
                    if (!heroesList.Any(hero => hero.Name == heroName))
                    {
                        heroesList.Add(new Hero(heroName));
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                }

                else if (heroInfo[0] == "Learn")
                {
                    string spellName = heroInfo[2];

                    Hero hero = heroesList.FirstOrDefault(hero => hero.Name == heroName);

                    if (hero != null)
                    {
                        hero.AddSpell(spellName);
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                }

                else if (heroInfo[0] == "Unlearn")
                {
                    string spellName = heroInfo[2];

                    Hero hero = heroesList.FirstOrDefault(hero => hero.Name == heroName);

                    if (hero != null)
                    {
                        hero.RemoveSpell(heroName, spellName);
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                }
            }

            PrintResult(heroesList);
        }

        static void PrintResult(List<Hero> heroesList)
        {
            Console.WriteLine("Heroes:");
            Console.WriteLine(string.Join(Environment.NewLine, heroesList));
        }
    }
}
