using System;

namespace _7.Theatre_Promotions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            //Day / Age         0 <= age <= 18      18 < age <= 64       64 < age <= 122

             // Weekday 12$ 18$ 12$

             // Weekend 15$ 20$ 15$

             // Holiday 5$ 12$ 10$

            switch (typeOfDay)
            {
                case "Weekday":
                    if (0 <= age && age <= 18)
                    { 
                        Console.WriteLine ("12$");
                        break;
                    }
                        else if (0 < age && age <= 64)
                    {
                        Console.WriteLine("18$");
                        break;
                    }
                    else if (0 < age && age <= 122)
                    {
                        Console.WriteLine("12$");
                        break;
                    }
                    else
                    { Console.WriteLine("Error!");
                        break;
                    }

                case "Weekend":
                    if (0 <= age && age <= 18)
                    {
                        Console.WriteLine("15$");
                        break;
                    }
                    else if (0 < age && age <= 64)
                    {
                        Console.WriteLine("20$");
                        break;
                    }
                    else if (0 < age && age <= 122)
                    {
                        Console.WriteLine("15$");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                        break;
                    }

                case "Holiday":
                    if (0 <= age && age <= 18)
                    {
                        Console.WriteLine("5$");
                        break;
                    }
                    else if (0 < age && age <= 64)
                    {
                        Console.WriteLine("12$");
                        break;
                    }
                    else if (0 < age && age <= 122)
                    {
                        Console.WriteLine("10$");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                        break;
                    }
            }

        }
    }
}
