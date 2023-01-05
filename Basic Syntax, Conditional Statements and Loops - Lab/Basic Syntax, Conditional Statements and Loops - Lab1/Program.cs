using System;
using System.Runtime.Intrinsics.Arm;

namespace Basic_Syntax__Conditional_Statements_and_Loops___Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:f2}");
        }
    }
}
