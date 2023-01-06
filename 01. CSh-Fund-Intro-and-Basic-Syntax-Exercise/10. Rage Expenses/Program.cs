using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrise = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headsetCrash = lostGames / 2;
            double mouseCrash = lostGames / 3;
            double keyboardCrash = lostGames / 6;
            double displayCrash = lostGames / 12;

            double headsetExp = headsetPrice * headsetCrash;
            double mouseExp = mousePrise * mouseCrash;  
            double keyboardExp = keyboardPrice * keyboardCrash;
            double displayExp = displayPrice * displayCrash;

            Console.WriteLine($"Rage expenses: {(headsetExp + mouseExp + keyboardExp + displayExp):f2} lv.");
        }
    }
}
