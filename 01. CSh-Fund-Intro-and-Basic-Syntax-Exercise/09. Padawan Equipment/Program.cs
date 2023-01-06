using System;

namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal numberOfStudents = decimal.Parse(Console.ReadLine());
            decimal lightsaberPrice = decimal.Parse(Console.ReadLine());    
            decimal robePrice = decimal.Parse(Console.ReadLine());
            decimal beltPrice = decimal.Parse(Console.ReadLine());

            decimal moreSabers = Math.Ceiling(numberOfStudents * 10/100);
            decimal allLightsabers = lightsaberPrice * (numberOfStudents + moreSabers);

            decimal allRobes = robePrice * numberOfStudents;

            decimal freeBelts = Math.Floor(numberOfStudents / 6);
            decimal allBelts = beltPrice * (numberOfStudents - freeBelts);

            decimal price = allLightsabers + allRobes + allBelts;

            if (price <= money)
                Console.WriteLine($"The money is enough - it would cost {price:f2}lv.");

            if (price > money)
                Console.WriteLine($"John will need {(price - money):f2}lv more.");
        }
    }
}
