using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int[] one = new int[lines];
            int[] two = new int[lines];

            for (int i = 0; i <= lines-1; i++)
            {
                
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 != 0)
                {
                    int temp = line[0];
                    line[0] = line[1];
                    line[1] = temp;
                }
                one[i] = line[0];
                two[i] = line[1];
                
            }

            for (int i = 0; i <= one.Length - 1; i++)
            {
                Console.Write(one[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i <= two.Length - 1; i++)
            {
                Console.Write(two[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
