using System;
using System.Runtime.ConstrainedExecution;

namespace _4.__Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            for (int i = word.Length-1; i >= 0; i--)
            {
                char curr = word[i];   
                Console.Write(curr);
            }
        }
    }
}
