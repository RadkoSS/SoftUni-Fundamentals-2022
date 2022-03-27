using System;
using System.Linq;
using System.Collections.Generic;

namespace P05._Bomb_Numbers
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] bombCharacteristics = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int bombNumber = bombCharacteristics[0];
            int bombPower = bombCharacteristics[1];

            while (numbers.Contains(bombNumber))
            {
                int indexOfBomb = numbers.IndexOf(bombNumber);

                DetonateBomb(numbers, indexOfBomb, bombPower);

            }

            Console.WriteLine(numbers.Sum());

        }

        static List<int> DetonateBomb(List<int> numbers, int indexOfBomb, int bombPower)
        {
            int rightCount = indexOfBomb + bombPower;

            for (int count = indexOfBomb; count <= rightCount; count++)
            {
                if (indexOfBomb >= numbers.Count)
                {
                    break;
                }

                numbers.RemoveAt(indexOfBomb);
            }

            int leftCount = indexOfBomb - bombPower;

            if (leftCount < 0)
            {
                leftCount = 0;
            }

            for (int count = leftCount; count < indexOfBomb; count++)
            {
                numbers.RemoveAt(leftCount);
            }

            return numbers;
        }
    }
}
