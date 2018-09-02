using System;
using System.Collections.Generic;
using System.Linq;

namespace Karaoke
{
    class Karaoke
    {
        public static void Main()
        {
            var singers = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var songs = Console.ReadLine()
                .Split(',').Select(x => x.Trim())
                .ToArray();

            var result = new Dictionary<string, List<string>>();

            var performance = Console.ReadLine();

            while (performance.ToLower() != "dawn")
            {
                var performanceSplit = performance
                    .Split(',')
                    .ToArray();

                var singer = performanceSplit[0].Trim();
                var song = performanceSplit[1].Trim();
                var award = performanceSplit[2].Trim();

                if (!result.ContainsKey(singer) && singers.Contains(singer) && songs.Contains(song))
                {
                    result.Add(singer, new List<string>());
                    result[singer].Add(award);
                }
                else if (singers.Contains(singer) && songs.Contains(song) && !result[singer].Contains(award))
                {
                    result[singer].Add(award);
                }

                performance = Console.ReadLine();
            }

            result = result
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x=> x.Value);

            if (result.Count == 0)
            {
                Console.WriteLine("No awards");
            }

            foreach (var singer in result)
            {
                Console.WriteLine($"{singer.Key}: {singer.Value.Count} awards");

                foreach (var item in singer.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"--{item}");
                }
            }
        }
    }
}