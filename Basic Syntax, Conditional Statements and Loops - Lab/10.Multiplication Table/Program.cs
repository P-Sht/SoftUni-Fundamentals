using System;

namespace _10.Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int times = 1;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {times} = {n * times}");
                times += 1;
            }
        }
    }
}
