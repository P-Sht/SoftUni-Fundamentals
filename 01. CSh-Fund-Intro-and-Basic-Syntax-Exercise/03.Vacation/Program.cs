using System;
using System.ComponentModel.DataAnnotations;

namespace _3.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double count = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double value = 0;
            double total = 0;


            if (type == "Students")
            {
                if (day == "Friday")
                    value = 8.45;
                else if (day == "Saturday")
                    value = 9.80;
                else
                    value = 10.46;

                total = count * value;

                if (count >= 30)
                {
                    total = total - total * 0.15;
                }

                Console.WriteLine($"Total price: {total:f2}");
            }

            else if (type == "Business")
            {
                if (day == "Friday")
                    value = 10.90;
                else if (day == "Saturday")
                    value = 15.60;
                else
                    value = 16;

                if (count >= 100)
                {
                    count = count - 10;
                }

                total = count * value;

                Console.WriteLine($"Total price: {total:f2}");
            }

            else
            {
                if (day == "Friday")
                    value = 15;
                else if (day == "Saturday")
                    value = 20;
                else
                    value = 22.50;

                total = count * value;

                if (10 <= count && count <= 20)
                {
                    total = total - total * 0.05;
                }

                Console.WriteLine($"Total price: {total:f2}");
            }


        }
    }
}
