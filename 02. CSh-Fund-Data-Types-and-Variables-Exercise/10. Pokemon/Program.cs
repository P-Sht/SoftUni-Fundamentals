using System;
using System.IO;

namespace _10._Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int originalN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine()); 
            int exhaustionY = int.Parse(Console.ReadLine());
            int targets = 0;
            int currentN = originalN;
            while (currentN >= distanceM)
            {
                    currentN -= distanceM;
                    targets++;
                    if (currentN == originalN * 0.5 && exhaustionY != 0)
                    {
                        currentN /= exhaustionY;
                    }
            }
            Console.WriteLine(currentN);
            Console.WriteLine(targets);
            
        }
    }
}
