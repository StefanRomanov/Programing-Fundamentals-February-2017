using System;
using System.Linq;
using System.Collections.Generic;

namespace Closest_Points
{
    class ClosestPoints
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            var listPoints = new List<Point>();

            for (int i = 0; i < number; i++)
            {
                var dimentions = Console.ReadLine()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();

                var currentPoint = new Point()
                {
                    X = dimentions[0],
                    Y = dimentions[1],
                };

                listPoints.Add(currentPoint);       
            }
            
            var minDistance = double.MaxValue;
            Point minFirstPoint = null;
            Point minSecondPoint = null;
            
            for (int i = 0; i < listPoints.Count - 1; i++)
            {
                for (int j = i + 1; j < listPoints.Count; j++)
                {
                    var firstPoint = listPoints[i];
                    var secondPoint = listPoints[j];
                    var currentDistance = GetDistance(firstPoint, secondPoint);

                    if (minDistance > currentDistance)
                    {
                        minDistance = currentDistance;

                        minFirstPoint = firstPoint;
                        minSecondPoint = secondPoint;
                    }
                }
            }

            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine($"({minFirstPoint.X}, {minFirstPoint.Y})");
            Console.WriteLine($"({minSecondPoint.X}, {minSecondPoint.Y})");
        }

        public static double GetDistance(Point firstPoint, Point secondPoint)
        {
            var componentOne = Math.Pow((firstPoint.X - secondPoint.X), 2);
            var componentTwo = Math.Pow((firstPoint.Y - secondPoint.Y), 2);

            var result = Math.Sqrt(componentOne + componentTwo);

            return result;
        }
    }
}
