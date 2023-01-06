using System;

namespace _02._Fundamentals_Data_Types_and_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if ((int)input > 95)
            {
                Console.WriteLine("lower-case");
            }
            else
            Console.WriteLine("upper-case");
        }
    }
}
