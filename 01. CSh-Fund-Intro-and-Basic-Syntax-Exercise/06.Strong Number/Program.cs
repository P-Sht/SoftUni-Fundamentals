using System;

namespace _6.Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            int numCopy = number;
            int factSum = 0;

            while (numCopy > 0)
            {
                int lastDigit = numCopy % 10;
                numCopy /= 10;

                int fact = 1;

                for (int i = 1; i <= lastDigit; i++)
                {
                    fact *= i;
                }
                factSum += fact;
            }
            if (factSum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
