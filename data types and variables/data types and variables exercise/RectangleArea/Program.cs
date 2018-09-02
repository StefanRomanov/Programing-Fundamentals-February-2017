using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProp
{
    class Program
    {
        static void Main(string[] args)
        {
            double aSide = double.Parse(Console.ReadLine());
            double bSide = double.Parse(Console.ReadLine());

            double perimeter = (aSide + bSide) * 2;

            double area = aSide * bSide;

            double diagonal = Math.Sqrt(Math.Pow(aSide,2) + Math.Pow(bSide,2));

            Console.WriteLine(perimeter);

            Console.WriteLine(area);

            Console.WriteLine(diagonal);
        }
    }
}
