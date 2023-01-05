using System;

namespace _9.Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            int red = 0;
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 2 != 0) && (red<count))
                {
                    Console.WriteLine(i);
                    red++;
                    sum += i;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
