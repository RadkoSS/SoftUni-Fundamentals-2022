using System;
using System.Linq;
using System.Collections.Generic;

namespace P07._Order_by_Age
{
    internal class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            EnterInformation(people);
            
            PrintFinalList(people);
        }
        static void EnterInformation(List<Person> people)
        {
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "End")
            {
                string[] input = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                if (people.Exists(person => person.Id == id))
                {
                    foreach (var item in people.Where(person => person.Id == id))
                    {
                        item.Name = name;
                        item.Age = age;
                    }
                }
                else
                {
                    Person newPerson = new Person(name, id, age);

                    people.Add(newPerson);
                }
            }
        }
        static void PrintFinalList(List<Person> people)
        {
            foreach (var person in people.OrderBy(people => people.Age))
            {
                Console.WriteLine(person);
            }
        }
        class Person
        {
            public Person(string name, string id, int age)
            {
                this.Name = name;
                this.Id = id;
                this.Age = age;
            }

            public string Name { get; set; }

            public string Id { get; set; }

            public int Age { get; set; }

            public override string ToString()
            {
                return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
            }
        }
    }
}
