using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Miner_Task
{
    class MinerTask
    {
        public static void Main()
        {
            var minedResources = new Dictionary<string, long>();

            var input = File.ReadAllLines("input.txt");

            var result = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                var command = input[i];

                if(command.ToLower() != "stop")
                {
                    if (i % 2 == 0)
                    {
                        if (!minedResources.ContainsKey(command))
                        {
                            minedResources.Add(command, 0);
                        }
                    }
                    else
                    {
                        var resourse = input[i - 1];
                        var quantity = int.Parse(input[i]);

                        minedResources[resourse] += quantity;
                    }        
                }
            }

            foreach (var entry in minedResources)
            {
                result.Add($"{entry.Key} -> {entry.Value}");
            }

            File.AppendAllLines("output.txt", result);
        }
    }
}
