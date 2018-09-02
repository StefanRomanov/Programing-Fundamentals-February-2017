using System;
using System.Globalization;

namespace DayOfWeek
{
    class DayOfWeek
    {
        public static void Main()
        {
            var userInput = Console.ReadLine();

            var date = DateTime.ParseExact(userInput, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}