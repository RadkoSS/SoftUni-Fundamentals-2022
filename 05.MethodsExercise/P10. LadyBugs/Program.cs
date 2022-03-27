using System;
using System.Linq;

namespace P10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            int[] ladyBugsIndexes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] ladyBugsOnField = new int[sizeOfField];

            for (int i = 0; i < ladyBugsOnField.Length; i++)
            {
                if (ladyBugsIndexes.Contains(i))
                {
                    ladyBugsOnField[i] = 1;
                }
            }

            string input = string.Empty;
            int[] finalResult = new int[ladyBugsOnField.Length];
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArgument = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                int currentIndex = int.Parse(inputArgument[0]);
                string direction = inputArgument[1];
                int flyLenght = int.Parse(inputArgument[2]);

                if (currentIndex < 0 || currentIndex >= ladyBugsOnField.Length)
                {
                    continue;
                }
                if (ladyBugsOnField[currentIndex] == 0)
                {
                    continue;
                }
                int nextIndexer = currentIndex;
                //while ((nextIndexer >= 0 && nextIndexer < ladyBugsOnField.Length) && ladyBugsOnField[nextIndexer] != 0)
                //{

                //}
                for (int i = 0; i < ladyBugsOnField.Length; i++)
                {
                    if (direction == "left")
                    {
                        nextIndexer -= flyLenght;
                    }
                    else if (direction == "right")
                    {
                        nextIndexer += flyLenght;
                    }
                    // TODO add case in which there is a ladybug and the other one needs to continue flying with the same flylenght
                    if (nextIndexer >= 0 && nextIndexer < ladyBugsOnField.Length)
                    {
                        if (ladyBugsOnField[nextIndexer] == 1)
                        {
                            nextIndexer += flyLenght;
                            if (nextIndexer < ladyBugsOnField.Length && nextIndexer >= 0)
                            {
                                finalResult[nextIndexer] = 1;
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            finalResult[nextIndexer] = 1;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(' ', finalResult));
        }
    }
}
