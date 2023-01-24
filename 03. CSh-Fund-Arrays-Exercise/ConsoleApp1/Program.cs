using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] items = line.Split();
            int[] ints = items.Select(int.Parse).ToArray();

            int times = int.Parse(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                int temp = ints[0];
                for (int j = 0; j < ints.Length-1; j++)
                {
                    ints[j] = ints[j + 1];
                }
                ints[ints.Length - 1] = temp;
            }
            Console.WriteLine(string.Join(" ", ints));
        }
    }
}
