using System;

namespace _01._CSharp_Fundamentals_Intro_and_Basic_Syntax_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            
            if (age >= 0 && age <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (3 <= age && age <= 13)
            {
                Console.WriteLine("child");
            }
            else if (14 <= age && age <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (20 <= age && age <= 65)
            {
                Console.WriteLine("adult");
            }
            else if (65 < age)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
