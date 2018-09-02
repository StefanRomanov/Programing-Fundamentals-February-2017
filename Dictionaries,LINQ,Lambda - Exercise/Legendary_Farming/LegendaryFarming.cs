using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class LegendaryFarming
    {
        public static void Main()
        {
            var legendary = string.Empty;

            var keyMats = new Dictionary<string, int>()
            {
                { "motes",0 },
                {"fragments", 0 },
                {"shards",0 }
            };

            var junk = new SortedDictionary<string, int>();

            while (keyMats["motes"] < 250 && keyMats["shards"] < 250 && keyMats["fragments"] < 250)
            {
                var materialsFound = Console.ReadLine().ToLower();

                var list = materialsFound.Split(' ').ToList();

                for (int i = 0; i < list.Count; i += 2)
                {
                    var value = int.Parse(list[i]);
                    var material = list[i + 1];

                    if (keyMats.ContainsKey(material))
                    {
                        keyMats[material] += value;
                    }
                    else if (!junk.ContainsKey(material))
                    {
                        junk.Add(material, value);
                    }
                    else
                    {
                        junk[material] += value;
                    }


                    if (keyMats["motes"] >= 250 || keyMats["shards"] >= 250 || keyMats["fragments"] >= 250)
                    {
                        break;
                    }
                }
            }

            PrintResult(keyMats, junk);
        }

        public static void PrintResult(Dictionary<string, int> keyMats, SortedDictionary<string, int> junk)
        {
            var legendaries = new Dictionary<string, string>()
            {
                {"motes","Dragonwrath"},
                {"shards","Shadowmourne"},
                {"fragments","Valanyr"},
            };

            var holder = keyMats.ToDictionary(x => x.Key, x => x.Value);

            foreach (var mat in holder)
            {
                if (mat.Value >= 250)
                {
                    Console.WriteLine($"{legendaries[mat.Key]} obtained!");

                    keyMats[mat.Key] -= 250;
                }
            }

            keyMats = keyMats.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var material in keyMats)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var material in junk)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}