using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Book_Library
{
    class BookLibrary
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            var booksList = new List<Book>();

            for (int i = 0; i < number; i++)
            {
                var data = Console.ReadLine().Split().ToList();

                var book = new Book()
                {
                    title = data[0],
                    author = data[1],
                    publisher = data[2],
                    ReleaseDate = DateTime.ParseExact(data[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = data[4],
                    price = decimal.Parse(data[5]),
                };

                booksList.Add(book);
            }

            var result = booksList
                .GroupBy(x => x.author)
                .Select(j => new
                {
                    author = j.Key,
                    prices = j.Sum(x => x.price)
                })
                .OrderByDescending(x => x.prices)
                .ThenBy(x => x.author)
                .ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.author} -> {item.prices:f2}");
            }
        }
    }
}
