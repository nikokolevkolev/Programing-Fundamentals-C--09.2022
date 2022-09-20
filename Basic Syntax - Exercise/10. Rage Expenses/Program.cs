using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keybordPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            //Action
            int headsetCnt = lostGames / 2;
            int mouseCnt = lostGames / 3;
            int keybordCnt = lostGames / 6;
            int displayCnt = lostGames / 12;

            //Output

            double expenses = (headsetCnt * headsetPrice) + (mouseCnt * mousePrice) +
                (keybordCnt * keybordPrice) + (displayCnt * displayPrice);
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");    
        }
    }
}
