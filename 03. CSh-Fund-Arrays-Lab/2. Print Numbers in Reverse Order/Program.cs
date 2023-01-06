using System;

namespace _2._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                numbers[i] = current;
            }
            for (int i = n-1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
