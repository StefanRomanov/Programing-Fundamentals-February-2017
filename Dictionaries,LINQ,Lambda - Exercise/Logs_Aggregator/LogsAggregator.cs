using System;
using System.Collections.Generic;
using System.Linq;

namespace Logs_Aggregator
{
    class LogsAggregator
    {
        public static void Main()
        {
            var inputCount = int.Parse(Console.ReadLine());

            var userTime = new SortedDictionary<string, int>();

            var userIp = new SortedDictionary<string, List<string>>();

            for (int i = 0; i < inputCount; i++)
            {
                var data = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                var name = data[1];
                var ip = data[0];
                var seconds = int.Parse(data[2]);

                if (!userTime.ContainsKey(name))
                {
                    userTime.Add(name, seconds);
                }
                else
                {
                    userTime[name] += seconds;
                }

                if (!userIp.ContainsKey(name))
                {
                    userIp.Add(name, new List<string>());
                    userIp[name].Add(ip);
                }
                else
                {
                    userIp[name].Add(ip);
                }

                userIp[name] = userIp[name]
                    .Distinct()
                    .OrderBy(x => x)
                    .ToList();
            }

            foreach (var user in userIp)
            {
                var ipAdresses = string.Join(", ", user.Value);

                Console.WriteLine($"{user.Key}: {userTime[user.Key]} [{ipAdresses}]");
            }
        }
    }
}
