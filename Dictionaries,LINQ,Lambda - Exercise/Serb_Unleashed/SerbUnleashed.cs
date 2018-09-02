using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Serb_Unleashed
{
    class SerbUnleashed
    {
        public static void Main()
        {
            var pattern = @"(.*?) @(.*?) (\d+) (\d+)";

            var userInput = Console.ReadLine().Trim();

            var venueSalesRegister = new Dictionary<string, Dictionary<string, long>>();

            while (userInput.ToLower() != "end")
            {
                var command = userInput.Split(' ').ToList();

                if (!Regex.IsMatch(userInput, pattern))
                {
                    userInput = Console.ReadLine();
                    continue;
                }

                string[] inputToArray = userInput.Split("@".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                string singerName = inputToArray[0].Trim();
                string[] concertInfo = inputToArray[1].Trim().Split().ToArray();
                int ticketPrice = int.Parse(concertInfo[concertInfo.Length - 2]);
                int ticketCount = int.Parse(concertInfo[concertInfo.Length - 1]);

                string venueName = string.Empty;
                for (int i = 0; i < concertInfo.Length - 2; i++)
                {
                    venueName += " " + concertInfo[i];
                }

                var ticketSales = ticketPrice * ticketCount;

                if (!venueSalesRegister.ContainsKey(venueName))
                {
                    venueSalesRegister.Add(venueName, new Dictionary<string, long>());
                    venueSalesRegister[venueName].Add("total", 0);
                }

                if (!venueSalesRegister[venueName].ContainsKey(singerName))
                {
                    venueSalesRegister[venueName].Add(singerName, ticketSales);
                    venueSalesRegister[venueName]["total"] += ticketSales;
                }
                else
                {
                    venueSalesRegister[venueName][singerName] += ticketSales;
                }

                venueSalesRegister[venueName] = venueSalesRegister[venueName]
                    .OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, x => x.Value);

                userInput = Console.ReadLine();
            }

            foreach (var record in venueSalesRegister)
            {
                Console.WriteLine(record.Key);
                foreach (var singer in record.Value)
                {
                    if (singer.Key != "total")
                    {
                        Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                    }
                }
            }
        }
    }
}
