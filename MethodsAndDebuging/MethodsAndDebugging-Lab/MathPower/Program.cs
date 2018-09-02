using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double userNum = double.Parse(Console.ReadLine());
            int userPower = int.Parse(Console.ReadLine());

            double result = Pow(userNum, userPower);

            Console.WriteLine(result);
        }
        public static double Pow(double number, int power)
        {
            double result = number;
            for (int i = 1; i < power; i++)
            {
               result *= number;
            }
            return result;
        }
    }
}
