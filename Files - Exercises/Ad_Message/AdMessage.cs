using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Ad_Message
{
    class AdMessage
    {
        public static void Main()
        {
            var input = int.Parse(File.ReadAllText("input.txt"));

            var output = new List<string>();

            var random = new Random();

            var phrases = new string[] 
            {   "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product.",
            };

            var events = new string[]
            {
                "Now I feel good.", 
                "I have succeeded with this product.", 
                "Makes miracles. I am happy of the results!", 
                "I cannot believe but now I feel awesome.", 
                "Try it yourself, I am very satisfied.", 
                "I feel great!",
            };

            var authors = new string[]
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            var cities = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            for (int i = 0; i < input; i++)
            {
                var phrase = phrases[random.Next(phrases.Length)];
                var evnt = events[random.Next(events.Length)];
                var author = authors[random.Next(authors.Length)];
                var city = cities[random.Next(cities.Length)];

                output.Add($"{phrase} {evnt} {author} - {city}");
            }

            File.AppendAllLines("output.txt", output);
        }
    }
}
