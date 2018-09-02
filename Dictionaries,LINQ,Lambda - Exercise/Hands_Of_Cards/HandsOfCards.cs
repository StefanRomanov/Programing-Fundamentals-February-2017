using System;
using System.Collections.Generic;
using System.Linq;


namespace Hands_Of_Cards
{
    class HandsOfCards
    {
        public static void Main()
        {
            var playerRegister = new Dictionary<string, string>();

            var finalRegister = new Dictionary<string, int>();

            var name = string.Empty;

            while (name != "JOKER")
            {
                var userInput = Console.ReadLine()
                    .Split(':')
                    .ToArray();

                name = userInput[0];

                if (name != "JOKER")
                {
                    var cards = userInput[1];

                    if (!playerRegister.ContainsKey(name))
                    {
                        playerRegister.Add(name, cards);
                    }
                    else
                    {
                        playerRegister[name] += cards;
                    }
                }

            }

            foreach (var item in playerRegister)
            {
                var temp = item.Value;

                var player  = item.Key;

                var cards = temp
                    .Trim()
                    .Split(", ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries)
                    .Distinct()
                    .ToList();

                finalRegister[player] = SumOfCards(cards);

            }

            foreach (var record in finalRegister)
            {
                Console.WriteLine($"{record.Key}: {record.Value}");
            }
        }

        public static int SumOfCards(List<string> cards)
        {

            var cardPowers = new Dictionary<string, int>()
            {
                { "2",2 },
                { "3",3 },
                { "4",4 },
                { "5",5 },
                { "6",6 },
                { "7",7 },
                { "8",8 },
                { "9",9 },
                { "10",10 },
                { "J",11 },
                { "Q",12 },
                { "K",13 },
                { "A",14 },
                { "C",1 },
                { "D",2 },
                { "H",3 },
                { "S",4 },
            };

            var sum = 0;

            foreach (var card in cards)
            {
                var type = card[card.Length-1].ToString();

                var power = card.Substring(0,card.Length - 1);

                sum += cardPowers[power] * cardPowers[type];
            }

            return sum;
        }
    }
}