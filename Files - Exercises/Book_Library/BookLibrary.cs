using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;

namespace Book_Library
{
    class BookLibrary
    {
        public static void Main()
        {
            var input = File.ReadAllLines("input.txt");

            var numberBooks = input[0];

            var listOfBooks = new List<Book>();

            var result = new List<string>();

            for (int i = 1; i < input.Length - 1; i++)
            {
                var bookData = input[i].Split().ToList();

                var currentBook = new Book()
                {
                    Title = bookData[0],
                    Author = bookData[1],
                    Publisher = bookData[2],
                    ReleaseDate = DateTime.ParseExact(bookData[3],"d.MM.yyyy",CultureInfo.InvariantCulture),
                    ISBN = bookData[4],
                    Price = decimal.Parse(bookData[5]),
                };

                listOfBooks.Add(currentBook);
            }

            var wantedDate = DateTime.ParseExact(input.Last(), "d.MM.yyyy", CultureInfo.InvariantCulture);

            var groupedBooks = listOfBooks
                .Where(d => d.ReleaseDate > wantedDate)
                .GroupBy( x => new { x.Title, x.ReleaseDate })
                .Select(g => new
                {
                    author = g.Key.Title,
                    date = g.Key.ReleaseDate,
                })
                .OrderBy(x => x.date)
                .ThenBy(x => x.author)
                .ToList();

            foreach (var book in groupedBooks)
            {
                result.Add($"{book.author} -> {book.date.ToString("d.MM.yyyy")}");
            }

            File.WriteAllLines("output.txt", result);
        }
    }
}
