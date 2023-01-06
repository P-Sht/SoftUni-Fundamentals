using System;

namespace _12_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isSpecial = false;
            
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int copy = i;
                while (copy > 0)
                {
                    sum += copy % 10;
                    copy = copy / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
