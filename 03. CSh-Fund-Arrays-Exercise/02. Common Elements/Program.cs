using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var one = Console.ReadLine();
            var two = Console.ReadLine();

            string[] itemsOne = one.Split();
            string[] itemsTwo = two.Split();

            for (int i = 0; i < itemsTwo.Length; i++)
            {
                for (int j = 0; j < itemsOne.Length; j++)
                {
                    if (itemsOne[j] == itemsTwo[i])
                        Console.Write(itemsOne[j] + " "); 
                }
            }
        }
    }
}
