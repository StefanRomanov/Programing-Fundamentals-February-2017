using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            byte userNum1 = byte.Parse(Console.ReadLine());
            byte userNum2 = byte.Parse(Console.ReadLine());

            for (int futureASCII = userNum1; futureASCII <= userNum2; futureASCII++)
            {
                Console.Write((char)futureASCII+" ");
            }
        }
    }
}
