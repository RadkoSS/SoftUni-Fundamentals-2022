using System;

namespace _10_Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal monitorPrice = decimal.Parse(Console.ReadLine());
            int headsetTrashingCounter = 0;
            int mouseTrashingCounter = 0;
            int keyboardTrashingCounter = 0;
            int monitorTrashingCounter = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsetTrashingCounter++;
                }
                if (i % 3 == 0)
                {
                    mouseTrashingCounter++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardTrashingCounter++;
                    if (keyboardTrashingCounter % 2 == 0)
                    {
                        monitorTrashingCounter++;
                    }
                }
            }
            decimal rageExpenses = headsetPrice * headsetTrashingCounter + mousePrice * mouseTrashingCounter + keyboardPrice * keyboardTrashingCounter + monitorPrice * monitorTrashingCounter;
            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}