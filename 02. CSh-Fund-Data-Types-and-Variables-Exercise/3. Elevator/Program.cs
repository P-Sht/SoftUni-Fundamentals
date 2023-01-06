using System;
using System.Diagnostics.CodeAnalysis;

namespace _3._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = 0;
            while (numberOfPeople > 0)
            {
                int left = numberOfPeople - capacity;
                courses++;
                numberOfPeople = left;
            }
            Console.WriteLine(courses);
        }
    }
}
