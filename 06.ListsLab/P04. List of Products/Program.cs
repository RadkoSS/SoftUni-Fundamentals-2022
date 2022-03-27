using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._List_of_Products
{
    internal class Program
    {
        static void Main()
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            
            List<string> productList = EnterProducts(numberOfProducts).ToList();
            
            PrintList(productList);
            
        }
        static List<string> EnterProducts(int numberOfProducts)
        {
            List<string> productList = new List<string>();

            for (int i = 0; i < numberOfProducts; i++)
            {
                string currentProduct = Console.ReadLine();
                productList.Add(currentProduct);
            }

            return productList;
        }
        
        static void PrintList(List<string> productList)
        {
            productList.Sort();
            for (int i = 0; i < productList.Count; i++)
            {
                int productNumber = i + 1;
                Console.WriteLine($"{productNumber}.{productList[i]}");
            }
        }
    }
}
