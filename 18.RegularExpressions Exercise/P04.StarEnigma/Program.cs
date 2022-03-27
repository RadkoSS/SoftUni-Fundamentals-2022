using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P04.StarEnigma
{
    internal class Program
    {
        static void Main()
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            string regexPattern = @"\@(?<name>[A-Za-z]+)[^\@\-\!\:\>]*?\:(\d+)[^\@\-\!\:\>]*?\!(?<attackType>[A|D])\![^\@\-\!\:\>]*?\-\>(\d+)";

            int numberOfMessages = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfMessages; i++)
            {
                string encryptedMessage = Console.ReadLine();

                string decryptedMessage = DecryptMessage(encryptedMessage);

                Match match = Regex.Match(decryptedMessage, regexPattern);

                if (match.Success)
                {
                    string planetName = match.Groups["name"].Value;
                    string attackType = match.Groups["attackType"].Value;

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }

                    else if (attackType == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            Console.WriteLine(FinalResult(attackedPlanets, destroyedPlanets));

        }

        static string DecryptMessage(string encryptedMessage)
        {
            StringBuilder decryptedMessage = new StringBuilder();
            int decryptionKey = ReturnDecryptionKey(encryptedMessage);

            foreach (char character in encryptedMessage)
            {
                char decryptedChar = (char)(character - decryptionKey);
                decryptedMessage.Append(decryptedChar);
            }

            return decryptedMessage.ToString();
        }

        static int ReturnDecryptionKey(string encryptedMessage)
        {
            string regexPattern = @"s|t|a|r{1}";

            MatchCollection matches = Regex.Matches(encryptedMessage, regexPattern, RegexOptions.IgnoreCase);

            return matches.Count;
        }
        
        static string FinalResult(List<string> attackedPlanets, List<string> destroyedPlanets)
        {
            StringBuilder finalResult = new StringBuilder();

            finalResult.AppendLine($"Attacked planets: {attackedPlanets.Count}");

            foreach (string planet in attackedPlanets.OrderBy(planetName => planetName))
            {
                finalResult.AppendLine($"-> {planet}");
            }

            finalResult.AppendLine($"Destroyed planets: {destroyedPlanets.Count}");

            foreach (string planet in destroyedPlanets.OrderBy(planetName => planetName))
            {
                finalResult.AppendLine($"-> {planet}");
            }

            return finalResult.ToString();
        }
    }
}
