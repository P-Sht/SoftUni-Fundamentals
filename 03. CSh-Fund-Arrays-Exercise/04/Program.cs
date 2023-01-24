using System;
using System.Linq;

namespace _04_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                int temp = line[0];
                for (int k = 0; k < line.Length-1; k++)
                {
                    line[k] = line[k + 1];
                }
                line[line.Length-1] = temp;
            }
            for (int j = 0; j <= line.Length-1; j++)
            {
                Console.Write(line[j] + " ");
            }
        }
    }
}
