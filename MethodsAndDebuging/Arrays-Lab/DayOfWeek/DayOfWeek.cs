using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            int dayNumber = int.Parse(Console.ReadLine());

            var daysOfWeek =new string[]{"Monday", "Tuesday", "Wednesday", "Thursday", "Friday","Saturday", "Sunday"};

            if (dayNumber >= 1 && dayNumber <= 7)
            {
                Console.WriteLine(daysOfWeek[dayNumber - 1]);
            }
            else
	        {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
