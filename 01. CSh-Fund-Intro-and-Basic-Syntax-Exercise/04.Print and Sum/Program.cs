﻿using System;

namespace _4.Print_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = start; i < end; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine(end);
            Console.WriteLine($"Sum: {sum+end}");
        }
    }
}
