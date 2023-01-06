using System;
using System.Diagnostics.CodeAnalysis;

namespace _7._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int empty = 255;
            int sum = 0;
            for (int i = 1; i <= lines; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters > empty)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += liters;
                    empty -= liters;
                }
                
            }
                Console.WriteLine(sum);
        }
    }
}
