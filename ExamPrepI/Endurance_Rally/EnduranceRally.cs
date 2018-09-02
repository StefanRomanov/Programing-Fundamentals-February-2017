using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endurance_Rally
{
    class EnduranceRally
    {
        public static void Main()
        {
            var drivers = Console.ReadLine().Split().ToArray();
            var track = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var checkpoints = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            foreach (var driver in drivers)
            {
                double fuel = (double)driver[0];

                for (int i = 0; i < track.Length; i++)
                {
                    if (checkpoints.Contains(i))
                    {
                        fuel += track[i];
                    }
                    else
                    {
                        fuel -= track[i];
                    }

                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {i}");
                        break;
                    }
                }

                if (fuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:f2}");
                }
            }
        }
    }
}
