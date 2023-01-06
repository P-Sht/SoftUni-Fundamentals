using System;

namespace _11_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Length: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            
            double V = (lenght * width * height) / 3;
            Console.Write($"Pyramid Volume: {V:f2}");
        }
    }
}
