using System;
using System.Linq;
using System.Collections.Generic;

namespace P03.MessagesManager
{
    public class User
    {
        public User(string name, int sentMessages, int receivedMessages)
        {
            Name = name;
            SentMessages = sentMessages;
            ReceivedMessages = receivedMessages;
        }

        public string Name { get; set; }

        public int SentMessages { get; set; }

        public int ReceivedMessages { get; set; }

        public override string ToString()
        {
            return $"{Name} - {SentMessages + ReceivedMessages}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            int capacity = int.Parse(Console.ReadLine());

            List<User> usersList = new List<User>();
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Statistics")
            {
                string[] parts = line.Split('=', StringSplitOptions.RemoveEmptyEntries);

                string commandType = parts[0];
                if (commandType == "Add")
                {
                    string userName = parts[1];
                    int sentMessages = int.Parse(parts[2]);
                    int receivedMessages = int.Parse(parts[3]);

                    if (!usersList.Any(user => user.Name == userName))
                    {
                        usersList.Add(new User(userName, sentMessages, receivedMessages));
                    }
                }

                else if (commandType == "Message")
                {
                    string sender = parts[1];
                    string receiver = parts[2];
                    
                    User userSender = usersList.FirstOrDefault(user => user.Name == sender);

                    User userReceiver = usersList.FirstOrDefault(user => user.Name == receiver);
                    
                    if (userSender != null && userReceiver != null)
                    {
                        userSender.SentMessages += 1;
                        userReceiver.ReceivedMessages += 1;

                        int senderTotalMessages = userSender.SentMessages + userSender.ReceivedMessages;

                        int receiverTotalMessages = userReceiver.SentMessages + userReceiver.ReceivedMessages;

                        if (senderTotalMessages >= capacity)
                        {
                            usersList.Remove(userSender);
                            Console.WriteLine($"{userSender.Name} reached the capacity!");
                        }

                        if (receiverTotalMessages >= capacity)
                        {
                            usersList.Remove(userReceiver);
                            Console.WriteLine($"{userReceiver.Name} reached the capacity!");
                        }
                    }
                }

                else if (commandType == "Empty")
                {
                    string userNameToRemove = parts[1];

                    if (userNameToRemove == "All")
                    {
                        usersList.Clear();
                    }
                    else
                    {
                        User userToRemove = usersList.FirstOrDefault(user => user.Name == userNameToRemove);

                        usersList.Remove(userToRemove);
                    }
                }
            }

            Console.WriteLine($"Users count: {usersList.Count}");
            Console.WriteLine(string.Join(Environment.NewLine, usersList));
        }
    }
}
