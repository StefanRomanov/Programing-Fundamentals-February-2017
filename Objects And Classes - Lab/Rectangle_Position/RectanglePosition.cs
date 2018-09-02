using System;
using System.Collections.Generic;
using System.Linq;

namespace Rectangle_Position
{
    class RectanglePosition
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var firstRectangle = new Rectangle()
            {
                left = firstInput[0],
                top = firstInput[1],
                width = firstInput[2],
                height = firstInput[3]
            };

            var secondInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var secondRectangle = new Rectangle()
            {
                left = secondInput[0],
                top = secondInput[1],
                width = secondInput[2],
                height = secondInput[3]
            };

            if (InsideOrNot(firstRectangle,secondRectangle))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        public static bool InsideOrNot(Rectangle first, Rectangle second)
        {
            bool result = first.left >= second.left && first.right <= second.right && first.top <= second.top && first.bottom >= second.bottom;

            return result;
        }
    }
}
