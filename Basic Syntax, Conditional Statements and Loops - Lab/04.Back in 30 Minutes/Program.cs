using System;

namespace Back_in_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            minute = minute + 30;


            if (minute >= 60)
            {
                minute = minute - 60;
                hour = hour + 1;
            }

            if (hour >= 24)
                hour = hour - 24;


            Console.WriteLine($"{hour}:{minute:d2}");
        }
    }
}
