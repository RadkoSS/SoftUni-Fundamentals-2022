using System;

namespace P02._Articles
{
    internal class Program
    {
        static void Main()
        {
            string[] book = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Article newArticle = new Article(book[0], book[1], book[2]);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] cmdArguments = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string action = cmdArguments[0];
                string newInformation = cmdArguments[1];

                if (action == "Edit")
                {
                    newArticle.EditArticle(newInformation);
                }
                else if (action == "ChangeAuthor")
                {
                    newArticle.ChangeAuthor(newInformation);
                }
                else if (action == "Rename")
                {
                    newArticle.Rename(newInformation);
                }
            }

            Console.WriteLine(newArticle);

            //Console.WriteLine($"{newArticle.Title} - {newArticle.Content}: {newArticle.Author}");
        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void EditArticle(string newContent) => Content = newContent;

        public void ChangeAuthor(string newAuthor) => Author = newAuthor;

        public void Rename(string newTitle) => Title = newTitle;

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
