using System;

namespace _8._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggest = string.Empty;
            double vol = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double currentVol = 3.14159265359 * radius * radius * height;
                if (currentVol > vol)
                {
                    vol = currentVol;
                    biggest = model;   
                }
            }
            Console.WriteLine(biggest);
        }
    }
}
