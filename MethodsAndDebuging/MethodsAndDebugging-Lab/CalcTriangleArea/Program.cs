using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double userSide = double.Parse(Console.ReadLine());
            double userHeight = double.Parse(Console.ReadLine());

            double area = TriangleArea(userSide, userHeight);
            Console.WriteLine(area);
        }
        public static double TriangleArea(double side, double height)
        {
            return (side * height) / 2;
        }
    }
}
