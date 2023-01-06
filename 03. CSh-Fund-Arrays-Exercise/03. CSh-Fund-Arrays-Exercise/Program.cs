using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] people = new int[number];
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                int vagon = int.Parse(Console.ReadLine());
                people[i] = vagon;
                sum += vagon;
            }

            for (int i = 0; i < number; i++)
            {
                Console.Write(people[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
