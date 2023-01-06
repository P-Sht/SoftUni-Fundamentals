using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballNumber = int.Parse(Console.ReadLine());
            BigInteger highestValue = BigInteger.MinusOne;
            int highestSnow = 0;
            int highestTime = 0;
            int highestQuality = 0;

            for (int i = 1; i <= snowballNumber; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger value = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                
                if (value > highestValue)
                {
                    highestValue = value;
                    highestSnow = snowballSnow;
                    highestTime = snowballTime;
                    highestQuality = snowballQuality;   
                }
            }
            Console.WriteLine($"{highestSnow} : {highestTime} = {highestValue} ({highestQuality})");
        }
    }
}
