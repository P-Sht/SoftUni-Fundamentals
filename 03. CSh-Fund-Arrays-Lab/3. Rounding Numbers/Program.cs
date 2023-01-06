using System;

namespace _3._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split();
            double[] values = new double[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                values[i] = double.Parse(numbers[i]);
            }
            int[] ints = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                ints[i] = (int)Math.Round(values[i], MidpointRounding.AwayFromZero);
            }
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine($"{values[i]} => {ints[i]}");
            }
            
        }
    }
}
