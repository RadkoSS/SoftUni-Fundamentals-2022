using System;
using System.Linq;
using System.Collections.Generic;

namespace P05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            RemoveNegativeAndReverse(numbers);
            
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
        }
        static List<int> RemoveNegativeAndReverse(List<int> list)
        {
            list.RemoveAll(x => x < 0);
            list.Reverse();
            return list;
        }
    }
}
