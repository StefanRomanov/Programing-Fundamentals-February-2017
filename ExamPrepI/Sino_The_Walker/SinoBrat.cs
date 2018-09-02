using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Globalization;

namespace Sino_The_Walker
{
    class SinoBrat
    {
        public static void Main()
        {
            var time = DateTime.ParseExact(Console.ReadLine(), "H:mm:ss",CultureInfo.InvariantCulture);
            var steps = int.Parse(Console.ReadLine());
            long secsPerStep = int.Parse(Console.ReadLine());

            double totalSecs = (steps * secsPerStep) % 86400;

            var result = time.AddSeconds(totalSecs);

            Console.WriteLine("Time Arrival: {0:HH:mm:ss}", result);
        }
    }
}