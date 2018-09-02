using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HolidaysBtwnTwoDates
{
    class Program
    {

        static void Main()

        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),"d.M.yyyy", null);

            var endDate = DateTime.ParseExact(Console.ReadLine(),"d.M.yyyy", null);

            var holidaysCount = 0;

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {

                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }

            }
            Console.WriteLine(holidaysCount);

        }
    }
}
