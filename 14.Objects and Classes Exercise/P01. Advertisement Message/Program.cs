using System;
using System.Collections.Generic;

namespace P01._Advertisement_Message
{
    internal class Program
    {
        static void Main()
        {
            List<string> phrases = new List<string> {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };

            List<string> events = new List<string> { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };

            List<string> authors = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            List<string> cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int fakeMessages = int.Parse(Console.ReadLine());

            List<FakeMessage> fakeAd = new List<FakeMessage>();

            for (int i = 0; i < fakeMessages; i++)
            {
                Random random = new Random();
                int fakePhrase = random.Next(0, phrases.Count);
                int fakeEvents = random.Next(0, events.Count);
                int fakeAuthors = random.Next(0, authors.Count);
                int fakeCities = random.Next(0, cities.Count);
                FakeMessage fakeMessage = new FakeMessage(phrases[fakePhrase], events[fakeEvents], authors[fakeAuthors], cities[fakeCities]);

                fakeAd.Add(fakeMessage);
            }

            foreach (FakeMessage fakeMessage in fakeAd)
            {
                Console.WriteLine($"{fakeMessage.Phrase} {fakeMessage.Event} {fakeMessage.Author} – {fakeMessage.City}.");
            }
        }
    }
    public class FakeMessage
    {
        public FakeMessage(string phrase, string @event, string author, string city)
        {
            this.Phrase = phrase;
            this.Event = @event;
            this.Author = author;
            this.City = city;
        }
        public string Phrase { get; set; }

        public string Event { get; set; }

        public string Author { get; set; }

        public string City { get; set; }

    }
}
