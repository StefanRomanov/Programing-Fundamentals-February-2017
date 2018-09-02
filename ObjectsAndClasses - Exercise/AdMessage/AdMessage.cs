using System;

namespace Ad_Message
{
    class AdMessage
    {
        public static void Main()
        {
            var phrases = new String[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of itscategory.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            var events = new String[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            var author = new String[]
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            var cities = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            var rng = new Random();

            var phrasesIndex = rng.Next(0, phrases.Length);
            var eventsIndex = rng.Next(0, events.Length);
            var citiesIndex = rng.Next(0, cities.Length);
            var authorIndex = rng.Next(0, author.Length);

            Console.WriteLine("{0} {1} {2} {3}", phrases[phrasesIndex], events[eventsIndex], cities[citiesIndex], author[authorIndex]);
        }
    }
}
