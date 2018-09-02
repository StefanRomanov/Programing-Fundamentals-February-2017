using System;
using System.Collections.Generic;
using System.Linq;

namespace Dragon_Army
{
    class DragonArmy
    {
        public static void Main()
        {
            int dragonCount = int.Parse(Console.ReadLine());

            var dragons = new Dictionary<string, SortedDictionary<string, decimal[]>>();

            for (int i = 0; i < dragonCount; i++)
            {
                var dragonData = Console.ReadLine().Split().ToList();

                var type = dragonData[0];
                var name = dragonData[1];
                int armor, damage, health;

                if (dragonData[2] != "null")
                {
                    damage = int.Parse(dragonData[2]);
                }
                else
                {
                    damage = 45;
                }
                if (dragonData[3] != "null")
                {
                    health = int.Parse(dragonData[3]);
                }
                else
                {
                    health = 250;
                }
                if (dragonData[4] != "null")
                {
                    armor = int.Parse(dragonData[4]);
                }
                else
                {
                    armor = 10;
                }

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new SortedDictionary<string, decimal[]>());
                }

                dragons[type][name] = new decimal[] { damage, health, armor };

            }

            foreach (var type in dragons)
            {
                var dragonRecords = type.Value;
                var dragonType = type.Key;

                var averageDamage = dragonRecords.Values.Average(x => x[0]);
                var averageHealth = dragonRecords.Values.Average(x => x[1]);
                var averageArmor = dragonRecords.Values.Average(x => x[2]);

                Console.WriteLine($"{dragonType}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var dragon in dragonRecords)
                {
                    var name = dragon.Key;
                    var stats = dragon.Value;

                    Console.WriteLine($"-{name} -> damage: {stats[0]}, health: {stats[1]}, armor: {stats[2]}");
                }
            }
        }
    }
}
