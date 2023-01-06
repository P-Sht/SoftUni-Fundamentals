using System;

namespace _3._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balanse = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double totalSpent = 0;

            while (command != "Game Time")
            {
                if (command == "OutFall 4" || command == "CS: OG" || command == "Zplinter Zell" || command == "Honored 2" || command == "RoverWatch" || command == "RoverWatch Origins Edition")
                {
                    if (balanse >= 0)
                    {
                        switch (command)
                        {
                            case "OutFall 4":
                                if (balanse >= 39.99)
                                {
                                    balanse -= 39.99;
                                    totalSpent += 39.99;
                                    Console.WriteLine("Bought OutFall 4");
                                }
                                else
                                {
                                    Console.WriteLine("Too Expensive");
                                }
                                break;

                            case "CS: OG":
                                if (balanse >= 15.99)
                                {
                                    balanse -= 15.99;
                                    totalSpent += 15.99;
                                    Console.WriteLine("Bought CS: OG");
                                }
                                else
                                {
                                    Console.WriteLine("Too Expensive");
                                }
                                break;
                            case "Zplinter Zell":
                                if (balanse >= 19.99)
                                {
                                    balanse -= 19.99;
                                    totalSpent += 19.99;
                                    Console.WriteLine("Bought Zplinter Zell");
                                }
                                else
                                {
                                    Console.WriteLine("Too Expensive");
                                }
                                break;
                            case "Honored 2":
                                if (balanse >= 59.99)
                                {
                                    balanse -= 59.99;
                                    totalSpent += 59.99;
                                    Console.WriteLine("Bought Honored 2");
                                }
                                else
                                {
                                    Console.WriteLine("Too Expensive");
                                }
                                break;
                            case "RoverWatch":
                                if (balanse >= 29.99)
                                {
                                    balanse -= 29.99;
                                    totalSpent += 29.99;
                                    Console.WriteLine("Bought RoverWatch");
                                }
                                else
                                {
                                    Console.WriteLine("Too Expensive");
                                }
                                break;
                            case "RoverWatch Origins Edition":
                                if (balanse >= 39.99)
                                {
                                    balanse -= 39.99;
                                    totalSpent += 39.99;
                                    Console.WriteLine("Bought RoverWatch Origins Edition");
                                }
                                else
                                {
                                    Console.WriteLine("Too Expensive");
                                }
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }

                else
                {
                    Console.WriteLine("Not Found");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balanse:f2}");
        }
    }
}
