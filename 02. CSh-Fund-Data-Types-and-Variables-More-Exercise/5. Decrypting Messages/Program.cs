using System;
using System.ComponentModel.DataAnnotations;

namespace _5._Decrypting_Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            string word = string.Empty;
            for (int i = 0; i < lines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                int number = ((int)letter) + key;
                char letter1 = (char)number;
                word += letter1;
            }
            Console.WriteLine(word);
        }
    }
}
