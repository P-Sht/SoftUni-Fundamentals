using System;
using System.Xml;

namespace _8._Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfRows; i++)
            {
                int numberOfCol = i;
                for (int j = 1; j <= numberOfCol; j++)
                Console.Write($"{i} ");
                Console.WriteLine();
            }
        }
    }
}
