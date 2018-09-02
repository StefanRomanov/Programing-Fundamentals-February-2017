using System;
using System.Linq;

namespace Distance_Between_Points
{
    class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firstPoint = new Point();
            var secondPoint = new Point();

            var firstInput = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            firstPoint.X = firstInput[0];
            firstPoint.Y = firstInput[1];

            var secondInput = Console.ReadLine()
                .Split(' ')
                .Select(Double.Parse)
                .ToArray();

            secondPoint.X = secondInput[0];
            secondPoint.Y = secondInput[1];

            Console.WriteLine($"{GetDistance(firstPoint, secondPoint):f3}");

        }

        public static double GetDistance (Point firstPoint, Point secondPoint)
        {
            var componentOne = Math.Pow((firstPoint.X - secondPoint.X),2);
            var componentTwo = Math.Pow((firstPoint.Y - secondPoint.Y), 2);

            var result = Math.Sqrt(componentOne + componentTwo);

            return result;
        }
    }
}
