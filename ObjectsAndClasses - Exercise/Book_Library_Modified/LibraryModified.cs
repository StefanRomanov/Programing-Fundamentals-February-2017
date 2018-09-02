using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Book_Library_Modified
{
    class LibraryModified
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

            DateTime refDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var result = booksList
                .Where(x => x.ReleaseDate > refDate)
                .GroupBy(c => new { c.title, c.ReleaseDate })
                .Select(j => new
                {
                    title = j.Key.title,
                    date = j.Key.ReleaseDate
                })
                .OrderBy(x => x.date)
                .ThenBy(x => x.title)
                .ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.title} -> {item.date.ToString("dd.MM.yyyy")}");
            }
        }
    }
}