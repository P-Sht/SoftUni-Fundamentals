using System;

namespace _01._CSharp_Fundamentals_Intro_and_Basic_Syntax_More_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            if (numOne > numTwo && numTwo >= numThree)
            {
                if (numTwo >= numThree)
                {
                    Console.WriteLine(numOne);
                    Console.WriteLine(numTwo);
                    Console.WriteLine(numThree);
                }
                else if (numTwo <= numThree)
                {
                    Console.WriteLine(numOne);
                    Console.WriteLine(numThree);
                    Console.WriteLine(numTwo);
                }
            }
            else if (numOne < numTwo && numTwo >= numThree)
            {
                if (numOne <= numThree)
                {
                    Console.WriteLine(numTwo);
                    Console.WriteLine(numThree);
                    Console.WriteLine(numOne);
                }
                else if (numOne >= numThree)
                {
                    Console.WriteLine(numTwo);
                    Console.WriteLine(numOne);
                    Console.WriteLine(numThree);
                }
            }
            else if (numTwo < numThree && numThree >= numOne)
            {
                if (numTwo >= numOne)
                {
                    Console.WriteLine(numThree);
                    Console.WriteLine(numTwo);
                    Console.WriteLine(numOne);
                }
                else if (numOne >= numTwo)
                {
                    Console.WriteLine(numThree);
                    Console.WriteLine(numOne);
                    Console.WriteLine(numTwo);
                }
            }
        }
    }
}
