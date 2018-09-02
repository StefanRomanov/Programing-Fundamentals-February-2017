using System;

namespace Sweet_Dessert
{
    class SweetDessert
    {
        public static void Main()
        {
            var money = decimal.Parse(Console.ReadLine());
            var guests = decimal.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggPrice = decimal.Parse(Console.ReadLine());
            var priceBerries = decimal.Parse(Console.ReadLine());

            var portions = Math.Ceiling(guests / 6);

            var bananasNeeded = portions * 2;
            var eggsNeeded = portions * 4;
            var berriesNeeded = portions * 0.2m;

            var moneyNeeded = bananasNeeded * bananaPrice + eggsNeeded * eggPrice + berriesNeeded * priceBerries;

            if (moneyNeeded <= money)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:f2}lv.");
            }
            else
            {
                var difference = moneyNeeded - money;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {difference:f2}lv more.");
            }
        }
    }
}