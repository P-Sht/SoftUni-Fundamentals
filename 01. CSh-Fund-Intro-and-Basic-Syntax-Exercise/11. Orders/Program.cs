using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            for (int i = 0; i < n; i++)
            {
                double prisePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                double price = days * capsulesCount * prisePerCapsule;
                totalPrice += price;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
            


        }
    }
}
