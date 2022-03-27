using System;
using System.Linq;
using System.Text;

namespace P03._1_School
{
    public class Picture
    {
        public string name;
        public string author;
        public double price;
        public int yearOfCreation;
        public string uniqueNumber;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of pictures: ");
            int numberOfPics = int.Parse(Console.ReadLine());
            Picture[] pictures = new Picture[numberOfPics];

            for (int picNumber = 0; picNumber < numberOfPics; picNumber++)
            {
                pictures[picNumber] = new Picture();
                Console.Write("Picture name: ");
                pictures[picNumber].name = Console.ReadLine();

                Console.Write("Picture author: ");
                pictures[picNumber].author = Console.ReadLine();

                Console.Write("Picture price: ");
                pictures[picNumber].price = double.Parse(Console.ReadLine());

                Console.Write("Picture year of creation: ");
                pictures[picNumber].yearOfCreation = int.Parse(Console.ReadLine());

                Console.Write("Picture unique number: ");
                pictures[picNumber].uniqueNumber = Console.ReadLine();
            }

            for (int picNumber = 0; picNumber < numberOfPics; picNumber++)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"The picture's name is \"{pictures[picNumber].name}\".");
                Console.WriteLine($"Author of the picture is {pictures[picNumber].author}.");
                Console.WriteLine($"The price is {pictures[picNumber].price}.");
                Console.WriteLine($"It was made in {pictures[picNumber].yearOfCreation}.");
                Console.WriteLine($"Unique number: {pictures[picNumber].uniqueNumber}");
                Console.WriteLine("--------------------------------");
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Do you want to delete info for any of the pictures? Use number 1 for \"Yes\" and 2 for \"No\".");
            int answer = int.Parse(Console.ReadLine());
            
            if (answer == 1)
            {
                Console.Write("Enter the unique number of the picture you want to delete: ");
                string uniqueNumDelete = Console.ReadLine();
                bool wasNotFound = true;
                for (int pictureNum = 0; pictureNum < numberOfPics; pictureNum++)
                {
                    if (pictures[pictureNum].uniqueNumber == uniqueNumDelete)
                    {
                        pictures[pictureNum].name = string.Empty;
                        pictures[pictureNum].author = string.Empty;
                        pictures[pictureNum].yearOfCreation = 0;
                        pictures[pictureNum].price = 0;
                        pictures[pictureNum].uniqueNumber = string.Empty;
                        wasNotFound = false;
                    }
                }
                if (wasNotFound)
                {
                    Console.WriteLine($"There was no picture with unique number: {uniqueNumDelete}.");
                }
            }
            else
            {
                Console.WriteLine("No picture was deleted.");
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Search pictures made by:");
            string searchName = Console.ReadLine();
            if (searchName == string.Empty)
            {
                for (int picNumber = 0; picNumber < numberOfPics; picNumber++)
                {
                    Console.WriteLine($"The picture's name is \"{pictures[picNumber].name}\".");
                    Console.WriteLine($"Author of the picture is {pictures[picNumber].author}.");
                    Console.WriteLine($"The price is {pictures[picNumber].price}.");
                    Console.WriteLine($"It was made in {pictures[picNumber].yearOfCreation}.");
                    Console.WriteLine($"Unique number: {pictures[picNumber].uniqueNumber}");
                }
            }
            else
            {
                bool wasNotFound = true;
                for (int picNumber = 0; picNumber < numberOfPics; picNumber++)
                {
                    if (pictures[picNumber].author == searchName)
                    {
                        Console.WriteLine($"The picture's name is \"{pictures[picNumber].name}\".");
                        Console.WriteLine($"Author of the picture is {pictures[picNumber].author}.");
                        Console.WriteLine($"The price is {pictures[picNumber].price}.");
                        Console.WriteLine($"It was made in {pictures[picNumber].yearOfCreation}.");
                        Console.WriteLine($"Unique number: {pictures[picNumber].uniqueNumber}");
                        wasNotFound = false;
                    }
                }
                if (wasNotFound)
                {
                    Console.WriteLine($"No picture was made by {searchName}.");
                }
            }
            double highestPrice = double.MinValue;

            for (int picNumber = 0; picNumber < numberOfPics; picNumber++)
            {
                if (pictures[picNumber].price > highestPrice)
                {
                    highestPrice = pictures[picNumber].price;
                }
            }

            for (int picNumber = 0; picNumber < numberOfPics; picNumber++)
            {
                if (pictures[picNumber].price == highestPrice)
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine($"Highest priced picture's name is \"{pictures[picNumber].name}\".");
                    Console.WriteLine($"Author of the picture is {pictures[picNumber].author}.");
                    Console.WriteLine($"The price is {pictures[picNumber].price}.");
                    Console.WriteLine($"It was made in {pictures[picNumber].yearOfCreation}.");
                    Console.WriteLine($"Unique number: {pictures[picNumber].uniqueNumber}");
                    Console.WriteLine("--------------------------------");
                }
            }

            Console.WriteLine("You can get the average price for a picture by an author or the average price for all pictures.");
            Console.WriteLine("Enter author name or leave empty:");
            
            string authorName = Console.ReadLine();
            double averagePrice = 0;
            int counter = 0;

            if (authorName == string.Empty)
            {
                for (int picNumber = 0; picNumber < numberOfPics; picNumber++)
                {
                    averagePrice += pictures[picNumber].price;
                }
                averagePrice /= numberOfPics;
                Console.WriteLine($"Average price of all pictures is {averagePrice:f2} lv.");
                Console.WriteLine("--------------------------------");
            }
            else
            {
                bool wasNotFound = true;
                for (int picNumber = 0; picNumber < numberOfPics; picNumber++)
                {
                    if (authorName == pictures[picNumber].author)
                    {
                        averagePrice += pictures[picNumber].price;
                        counter++;
                        wasNotFound = false;
                    }
                }
                if (wasNotFound)
                {
                    Console.WriteLine("There is no such author.");
                    Console.WriteLine("--------------------------------");
                }
                else
                {
                    averagePrice /= counter;
                    Console.WriteLine($"Average price of all pictures by {authorName} is {averagePrice:f2} lv.");
                    Console.WriteLine("--------------------------------");
                }
            }
        }
    }
}
