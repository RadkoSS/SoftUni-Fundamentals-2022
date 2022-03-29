using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P02.MirrorWords
{
    internal class Program
    {
        static void Main()
        {
            Regex regex = new Regex(@"(\@|\#)(?<word>[A-Za-z]{3,})(\1)(\1)(?<word2>[A-Za-z]{3,})(\1)");

            string text = Console.ReadLine();

            MatchCollection matches = regex.Matches(text);

            List<string> matchedWords = new List<string>();

            foreach (Match match in matches)
            {
                string firstWord = match.Groups["word"].Value;
                string secondWord = match.Groups["word2"].Value;

                string firstWordReversed = ReverseStrings(firstWord);

                if (firstWordReversed == secondWord)
                {
                    matchedWords.Add($"{firstWord} <=> {secondWord}");
                }
            }

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            if (matchedWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", matchedWords));
            }
            
        }

        static string ReverseStrings(string word)
        {
            char[] reversedWordArray = word.ToCharArray().Reverse().ToArray();

            return string.Join(string.Empty, reversedWordArray);
        }
    }
}
