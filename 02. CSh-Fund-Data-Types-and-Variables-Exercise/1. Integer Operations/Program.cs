using System;

namespace _1._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int furstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());  
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            int sum = furstNum + secondNum;
            int div = sum / thirdNum;
            int mult = div * fourthNum; 

            Console.WriteLine(mult);

        }
    }
}
