using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Nether_Realm
{
    public class Demon
    {
        public string Name { get; set; }
        public BigInteger Health { get; set; }
        public decimal Damage { get; set; }
    }
    class NetherRealm
    {
        public static void Main()
        {
            var numbers = new Regex("[-+]?\\d+(\\.\\d+)*");
            var letters = new Regex("[^\\d+-.\\/*]");

            var demons = Console.ReadLine()
                .Split(new[] { ',', ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var listOfDemons = new List<Demon>();

            for (int i = 0; i < demons.Length; i++)
            {
                var lettersInName = letters.Matches(demons[i]);
                var numbersInName = numbers.Matches(demons[i]);
                var numberSum = 0.0m;
                BigInteger letterSum = 0;

                foreach (Match letter in lettersInName)
                {
                    letterSum += (int)(char.Parse(letter.ToString()));
                }
                foreach (var number in numbersInName)
                {
                    numberSum += decimal.Parse(number.ToString());
                }

                foreach (var symbol in demons[i])
                {
                    if (symbol == '/')
                    {
                        numberSum /= 2;
                    }
                    else if (symbol == '*')
                    {
                        numberSum *= 2;
                    }
                }

                var demon = new Demon();
                demon.Name = demons[i];
                demon.Damage = numberSum;
                demon.Health = letterSum;
                listOfDemons.Add(demon);
            }

            foreach (var demon in listOfDemons.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }
    }
}