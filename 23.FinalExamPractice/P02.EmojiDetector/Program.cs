using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02.EmojiDetector
{
    internal class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            Regex regex = new Regex(@"(\:\:|\*\*)(?<emoji>[A-Z]{1}[a-z]{2,})(\1)");

            MatchCollection matches = regex.Matches(text);

            List<string> coolEmojis = new List<string>();

            long coolThreshold = GetCoolThreshold(text);

            foreach (Match match in matches)
            {
                string emojiName = match.Groups["emoji"].Value;

                long coolnessOfEmoji = GetEmojiCoolnes(emojiName);

                if (coolnessOfEmoji >= coolThreshold)
                {
                    coolEmojis.Add($"{match.Groups[1]}{emojiName}{match.Groups[1]}");
                }
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");

            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");

            Console.WriteLine(string.Join(Environment.NewLine, coolEmojis));
        }

        static long GetCoolThreshold(string text)
        {
            long coolThreshold = 1;

            foreach (char character in text)
            {
                if (char.IsDigit(character))
                {
                    coolThreshold *= (character - '0');
                }
            }

            return coolThreshold;
        }

        static long GetEmojiCoolnes(string emoji)
        {
            long coolnessOfEmoji = 0;

            foreach (char character in emoji)
            {
                coolnessOfEmoji += character;
            }

            return coolnessOfEmoji;
        }
    }
}
