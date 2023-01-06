using System;

namespace _5._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int lines = int.Parse(Console.ReadLine());
                string word = String.Empty;

                for (int i = 0; i < lines; i++)
                {
                    string input = Console.ReadLine();
                    int number = int.Parse(input);
                    int digit = number % 10;
                    int offset = (digit - 2)*3;
                    if (digit == 0)
                        word += ' ';
                    else if (digit > 7)
                        word += (char)(97 + offset + input.Length);
                    else
                        word += (char)(97 + offset + input.Length - 1);
                }
                Console.WriteLine(word);
        }
    }
}
