using System;
using System.Linq;
using System.Collections.Generic;

namespace P03._Articles_2._0
{
    internal class Program
    {
        static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<Article> articles = GetArticle(numberOfCommands);

            string criteria = Console.ReadLine();
            if (criteria == "title")
            {
                articles = articles.OrderBy(a => a.Title).ToList();
            }

            else if (criteria == "content")
            {
                articles = articles.OrderBy(a => a.Content).ToList();
            }

            else if (criteria == "author")
            {
                articles = articles.OrderBy(a => a.Author).ToList();
            }

            PrintArticles(articles);
        }

        static List<Article> GetArticle(int numberOfCommands)
        {
            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] articlesArgs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string title = articlesArgs[0];
                string content = articlesArgs[1];
                string author = articlesArgs[2];

                Article article = new Article(title, content, author);

                articles.Add(article);

            }
            return articles;
        }

        static void PrintArticles(List<Article> articles)
        {
            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }
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

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
