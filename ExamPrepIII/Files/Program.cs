using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Files
{
    class File
    {
        public string Name { get; set; }
        public long Size { get; set; }
    }

    class Program
    {
        public static void Main()
        {
            var format = new Regex("\\b(.+?)\\\\(.+\\\\)?(.+\\..+);(\\d+)\\b");
            var result = new Dictionary<string, List<File>>();

            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var path = Console.ReadLine();

                if (!format.IsMatch(path))
                {
                    continue;
                }
                var match = format.Match(path);

                var root = match.Groups[1].ToString();
                var file = match.Groups[3].ToString();
                var fileSize = long.Parse(match.Groups[4].ToString());

                var newFile = new File()
                {
                    Name = file,
                    Size = fileSize
                };

                if (!result.ContainsKey(root))
                {
                    result.Add(root, new List<File>());
                }
                result[root].RemoveAll(x => x.Name == file);
                result[root].Add(newFile);
            }

            var command = Console.ReadLine().Split().ToArray();

            var extentionNeeded = command[0];
            var rootNeeded = command[2];

            var foundResult = false;

            foreach (var kvp in result)
            {
                if (kvp.Key == rootNeeded)
                {
                    foreach (var file in kvp.Value.OrderByDescending(x => x.Size).ThenBy(x => x.Name))
                    {
                        if (file.Name.EndsWith(extentionNeeded))
                        {
                            Console.WriteLine($"{file.Name} - {file.Size} KB");
                            foundResult = true;
                        }
                    }
                }
            }

            if (foundResult == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}