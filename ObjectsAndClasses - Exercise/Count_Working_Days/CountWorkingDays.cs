using System;
using System.Linq;
using System.Globalization;

namespace Count_Working_Days
{
    public class CountWorkingDays
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine();
            var secondInput = Console.ReadLine();

            var firstDate = DateTime.ParseExact(firstInput, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var secondDate = DateTime.ParseExact(secondInput, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var workingDays = 0;

            DateTime[] holidays = new DateTime[12];

            holidays[0] = new DateTime(12, 01, 01);
            holidays[1] = new DateTime(12, 03, 03);
            holidays[2] = new DateTime(12, 05, 01);
            holidays[3] = new DateTime(12, 05, 06);
            holidays[4] = new DateTime(12, 05, 24);
            holidays[5] = new DateTime(12, 09, 06);
            holidays[6] = new DateTime(12, 09, 22);
            holidays[7] = new DateTime(12, 11, 01);
            holidays[9] = new DateTime(12, 12, 24);
            holidays[10] = new DateTime(12, 12, 25);
            holidays[11] = new DateTime(12, 12, 26);

            for (var i = firstDate; i <= secondDate; i = i.AddDays(1))
            {
                var dayOfWeek = i.DayOfWeek;
                var currentDate = i;
                var tempDate = new DateTime(12, currentDate.Month, currentDate.Day);


                if ((dayOfWeek != DayOfWeek.Saturday && dayOfWeek != DayOfWeek.Sunday) && !holidays.Contains(tempDate))
                {
                    workingDays++;
                }

            }

            Console.WriteLine(workingDays);
        }
    }
}
