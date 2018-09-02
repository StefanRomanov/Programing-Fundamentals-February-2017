using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefractorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Length: ");
            var length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            var width = double.Parse(Console.ReadLine());
            Console.Write("Heigth: ");
            var height = double.Parse(Console.ReadLine());
            double volumePyramid = (length + width + height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volumePyramid);
        }
    }
}
