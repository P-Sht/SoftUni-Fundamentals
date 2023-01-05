using System;
using System.Runtime.Intrinsics.Arm;

namespace _12.Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    return;
                }
                else
                {
                    Console.WriteLine($"Please write an even number.");
                }
                num = int.Parse(Console.ReadLine());
            }
        }
    }

}
