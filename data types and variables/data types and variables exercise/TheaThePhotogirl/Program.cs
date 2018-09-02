using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TheaThePhotogirl
{
    class Program
    {
        static void Main(string[] args)
        {
            long totalPhotos = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long filterSeconds = totalPhotos * filterTime;
            long filteredPhotos = (long)Math.Ceiling(totalPhotos * filterFactor / 100.0);
            long uploadSeconds = filteredPhotos * uploadTime;

            long totalSeconds = filterSeconds + uploadSeconds;

            long days = totalSeconds / 86400;

            totalSeconds = totalSeconds % 86400;

            int hours = (int)totalSeconds / 3600;

            totalSeconds = totalSeconds % 3600;

            int minutes = (int)totalSeconds / 60;

            totalSeconds = totalSeconds % 60;

            int seconds = (int)totalSeconds;

            Console.WriteLine(($"{days}:{hours:00}:{minutes:00}:{seconds:00}"));
        }
    }
}
