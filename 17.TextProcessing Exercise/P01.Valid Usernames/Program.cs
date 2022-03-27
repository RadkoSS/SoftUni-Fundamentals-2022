using System;
using System.Text;

namespace P01.Valid_Usernames
{
    internal class Program
    {
        static void Main()
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder validUsernames = new StringBuilder();

            foreach (string username in usernames)
            {
                char[] currentUsername = username.ToCharArray();
                
                if (UsernameIsValid(currentUsername))
                {
                    validUsernames.AppendLine(username);
                }

            }

            Console.WriteLine(validUsernames.ToString().Trim());
        }
        static bool UsernameIsValid(char[] username)
        {
            bool isValid = false;

            if (username.Length >= 3 && username.Length <= 16)
            {
                foreach (char symbol in username)
                {
                    if (char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_')
                    {
                        isValid = true;
                    }

                    else
                    {
                        isValid = false;
                        break;
                    }
                }
            }

            return isValid;
        }
    }
}
