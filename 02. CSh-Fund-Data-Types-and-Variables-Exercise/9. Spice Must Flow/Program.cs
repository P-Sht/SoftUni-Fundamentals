using System;

namespace _9._Spice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yeild = int.Parse(Console.ReadLine());
            int all = 0;
            int days = 0;
            if (yeild >= 100)
            {
                while (yeild >= 100)
                {
                    days++;
                    all += yeild;
                    yeild -= 10;
                }
                all -= (days + 1) * 26;
                Console.WriteLine(days);
                Console.WriteLine(all);
            }
            else
            {
                Console.WriteLine(days);
                Console.WriteLine(all);
            }
        }
    }
}
