using System;
using System.IO;

namespace _5.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = "";

                for (int i = username.Length-1; i >=0 ; i--)
            {
                char curent = username [i];
                pass += curent;
            }
            
            string login = Console.ReadLine();

            for (int i = 1; i <= 5; i++)
            {
                if (i >= 4 && login != pass)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                if (login != pass)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                
                login = Console.ReadLine();
                
            }
            
        }
    }
}
