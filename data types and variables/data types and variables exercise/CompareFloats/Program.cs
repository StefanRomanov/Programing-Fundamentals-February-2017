using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double userNum1 = double.Parse(Console.ReadLine());
            double userNum2 = double.Parse(Console.ReadLine());

            double precision = 0.000001;

            double difference = Math.Abs(userNum1 - userNum2);

            if (difference >= precision)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
