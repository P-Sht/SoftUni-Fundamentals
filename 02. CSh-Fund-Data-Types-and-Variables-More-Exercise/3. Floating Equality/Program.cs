using System;

namespace _3._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());

            if (Math.Abs(numOne - numTwo) < 0.000001)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False"); 
            }
        }
    }
}
