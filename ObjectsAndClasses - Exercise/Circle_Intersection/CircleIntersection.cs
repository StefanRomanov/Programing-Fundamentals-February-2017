using System;
using System.Linq;

namespace Circle_Intersection
{
    class CircleIntersection
    {
        public static void Main()
        {
            var firstData = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var secondData = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var firstCenter = new Point()
            {
                X = firstData[0],
                Y = firstData[1]
            };

            var secondCenter = new Point()
            {
                X = secondData[0],
                Y = secondData[1]
            };

            var firstCircle = new Circle()
            {
                radius = firstData[2],
                center = firstCenter,
            };

            var secondCircle = new Circle()
            {
                radius = secondData[2],
                center = secondCenter,
            };

            if (Intersection(firstCircle,secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }

        public static bool Intersection(Circle first, Circle second)
        {
            var radiusDistance = Math.Sqrt(Math.Pow((first.center.X - second.center.X), 2) + Math.Pow((first.center.Y - second.center.Y), 2));

            if (first.radius + second.radius >= radiusDistance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
