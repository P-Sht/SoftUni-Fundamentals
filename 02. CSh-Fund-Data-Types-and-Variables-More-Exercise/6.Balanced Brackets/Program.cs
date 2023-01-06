using System;
using System.Threading;

namespace _6.Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int opening = 0;
            int closed = 0;

            for (int i = 1; i <= lines; i++)
            {
                string input = Console.ReadLine();
                
                if (input == "(")
                {
                    opening++;
                }
               
                if (input == ")")
                {
                    closed++;
                    if (opening - closed != 0)
                        break;
                }
            }

            if (opening == closed)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
