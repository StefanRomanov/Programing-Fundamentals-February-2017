using System;
using System.Collections.Generic;
using System.Linq;
namespace MinerTask
{
    class MinerTask
    {
        public static void Main()
        {
            var command = string.Empty;

            var resources = new Dictionary<string, int>();

            var metal = string.Empty;

            var quantity = 0;

            while (command != "stop")
            {

                for (int i = 0; i < 2; i++)
                {
                    var entry = Console.ReadLine();

                    if (i == 0 && entry != "stop")
                    {
                        metal = entry;
                        command = entry;
                    }
                    else if(i == 1 && entry != "stop")
                    {
                        quantity = int.Parse(entry);
                    }
                    else
                    {
                        command = entry;
                        break;
                    }

                    if (!resources.ContainsKey(metal))
                    {
                        resources[metal] = quantity;
                    }
                    else
                    {
                        resources[metal] += quantity;
                    }

                    quantity = 0;
                }

            }

            foreach (var record in resources)
            {
                Console.WriteLine($"{record.Key} -> {record.Value}");
            }
        }
    }
}
