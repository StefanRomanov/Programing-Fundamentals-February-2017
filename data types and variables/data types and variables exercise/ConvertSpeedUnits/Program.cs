using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int userMeters = int.Parse(Console.ReadLine());
            sbyte userHours = sbyte.Parse(Console.ReadLine());
            sbyte userMinutes = sbyte.Parse(Console.ReadLine());
            sbyte userSeconds = sbyte.Parse(Console.ReadLine());

            float hoursTotal = userHours + userMinutes / 60.0f + userSeconds / 3600.0f;
            float kph = (userMeters / 1000.0f) / hoursTotal;
            float mps = kph / 3.6f;
            float miles = userMeters / 1609.0f;
            float mph = miles / hoursTotal;

            Console.WriteLine(mps);

            Console.WriteLine(kph);

            Console.WriteLine(mph);
        }
    }
}
