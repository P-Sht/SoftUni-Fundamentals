using System;

namespace _11.Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multipl = int.Parse(Console.ReadLine());

            if (multipl < 10)
                for (int i = multipl; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {multipl} = {n * multipl}");
                multipl += 1;
            }

            else if (multipl >= 10)
            {
                Console.WriteLine($"{n} X {multipl} = {n * multipl}");
            }
        }
    }
}
