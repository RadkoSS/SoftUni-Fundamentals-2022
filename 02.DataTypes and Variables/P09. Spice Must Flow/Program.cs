using System;

namespace P09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int WorkerFee = 26;
            long startingYield = long.Parse(Console.ReadLine());
            int miningDays = 0;
            long totalYield = 0;

            while (startingYield >= 100)
            {
                miningDays++;
                totalYield += startingYield;
                totalYield -= WorkerFee;
                startingYield -= 10;
            }

            if (WorkerFee <= totalYield)
            {
                totalYield -= WorkerFee;
            }

            Console.WriteLine(miningDays);
            Console.WriteLine(totalYield);
        }
    }
}
