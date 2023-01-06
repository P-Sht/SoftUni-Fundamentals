using System;

namespace _7._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sum = 0;

            while (command != "Start")
            {
                double inserted = double.Parse(command);
                if (inserted == 0.1 || inserted == 0.2 || inserted == 0.5 || inserted == 1 || inserted == 2)
                    sum += inserted;
                else
                    Console.WriteLine($"Cannot accept {inserted}");
                command = Console.ReadLine();
            }

            while (command != "End")
            {
                command = Console.ReadLine();
                if (command == "End")
                    break;
                if (command != "Nuts" && command != "Water" && command != "Crisps" && command != "Soda" && command != "Coke")
                    Console.WriteLine("Invalid product");
                else if (command == "Nuts" && sum >= 2)
                {
                    Console.WriteLine("Purchased nuts");
                    sum -= 2; 
                }
                else if (command == "Water" && sum >= 0.7)
                {
                    Console.WriteLine("Purchased water");
                    sum -= 0.7; 
                }
                else if (command == "Crisps" && sum >= 1.5)
                {
                    Console.WriteLine("Purchased crisps");
                    sum -= 1.5; 
                }
                else if (command == "Soda" && sum >= 0.8)
                {
                    Console.WriteLine("Purchased soda");
                    sum -= 0.8; 
                }
                else if (command == "Coke" && sum >= 1)
                {
                    Console.WriteLine("Purchased coke");
                    sum -= 1; 
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                if (command == "End")
                    break;
            }

            if (sum >= 0)
            {
                Console.WriteLine($"Change: {sum:f2}");
            }
        }
    }
}
