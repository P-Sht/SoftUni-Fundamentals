using System;
using System.Linq;

namespace _4._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entryes = Console.ReadLine().Split();
            
            for (int i = entryes.Length-1; i >= 0; i--)
            {
                Console.Write($"{entryes[i]} ");
            }
            
        }
    }
}
