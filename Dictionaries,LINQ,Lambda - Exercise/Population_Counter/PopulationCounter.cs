using System;
using System.Collections.Generic;
using System.Linq;

namespace Population_Counter
{
    class PopulationCounter
    {
        public static void Main()
        {
            var command = Console.ReadLine();

            var finalRegister = new Dictionary<string, Dictionary<string, long>>();

            while (command != "report")
            {
                var commandArray = command
                    .Split('|')
                    .ToArray();

                var city = commandArray[0];
                var country = commandArray[1];
                var population = long.Parse(commandArray[2]);

                if (!finalRegister.ContainsKey(country))
                {
                    finalRegister.Add(country, new Dictionary<string, long>());
                    finalRegister[country].Add("total", 0);
                }

                if (!finalRegister[country].ContainsKey(city))
                {
                    finalRegister[country].Add(city, population);
                    finalRegister[country]["total"] += population;
                }
                else
                {
                    finalRegister[country][city] += population;
                }

                finalRegister = finalRegister
                    .OrderByDescending(x => x.Value["total"])
                    .ToDictionary(x => x.Key, x => x.Value);

                finalRegister[country] = finalRegister[country]
                    .OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, x => x.Value);

                command = Console.ReadLine();
            }

            foreach (var country in finalRegister)
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value["total"]})");
                foreach (var city in country.Value)
                {
                    if (city.Key != "total")
                    {
                        Console.WriteLine($"=>{city.Key}: {city.Value}");
                    }
                }
            }
        }
    }
}
