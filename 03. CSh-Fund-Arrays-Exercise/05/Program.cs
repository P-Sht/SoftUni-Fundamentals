using System;
using System.Linq;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for (int i = 0; i < line.Length; i++)
            {
                bool isBigger = true;
                for (int k = i+1; k < line.Length; k++)
                {
                    if (line[i] <= line[k])
                    {
                        isBigger = false;
                    }
                }
                if (isBigger)
                {
                    Console.Write(line[i] + " ");
                }
            }
        }
    }
}
