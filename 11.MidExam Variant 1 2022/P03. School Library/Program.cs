using System;
using System.Linq;
using System.Collections.Generic;

namespace P03._School_Library
{
    internal class Program
    {
        static void Main()
        {
            List<string> booksShelf = Console.ReadLine().Split('&', StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Done")
            {
                string[] books = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string commandType = books[0];

                if (commandType == "Add Book")
                {
                    string currBook = books[1];

                    if (booksShelf.Contains(currBook))
                    {
                        continue;
                    }
                    else
                    {
                        booksShelf.Insert(0, currBook);
                    }
                }

                else if (commandType == "Take Book")
                {
                    string currBook = books[1];

                    if (booksShelf.Contains(currBook))
                    {
                        booksShelf.Remove(currBook);
                    }
                    else
                    {
                        continue;
                    }
                }

                else if (commandType == "Swap Books")
                {
                    string firstBook = books[1];
                    string secondBook = books[2];

                    if (booksShelf.Contains(firstBook) && booksShelf.Contains(secondBook))
                    {
                        int firstIndex = booksShelf.IndexOf(firstBook);
                        int secondIndex = booksShelf.IndexOf(secondBook);
                        Swap(booksShelf, firstIndex, secondIndex);
                    }

                    else
                    {
                        continue;
                    }
                }

                else if (commandType == "Insert Book")
                {
                    string bookToInsert = books[1];

                    if (booksShelf.Contains(bookToInsert))
                    {
                        continue;
                    }
                    else
                    {
                        booksShelf.Add(bookToInsert);
                    }
                }

                else if (commandType == "Check Book")
                {
                    int index = int.Parse(books[1]);
                    if (index < 0 || index >= booksShelf.Count)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(booksShelf[index]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", booksShelf));
        }
        public static List<string> Swap(List<string> booksShelf, int firstBookIndex, int secondBookIndex)
        {
            string temp = booksShelf[firstBookIndex];
            booksShelf[firstBookIndex] = booksShelf[secondBookIndex];
            booksShelf[secondBookIndex] = temp;

            return booksShelf;
        }
    }
}
