using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace numN_to_num10
{
    class Nto10
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();

            var countSystem = int.Parse(input[0]);
            var number = BigInteger.Parse(input[1]);
            var power = 0;
            BigInteger result = 0;

            while (number > 0)
            {
                var lastDigit = number % 10;
                result += lastDigit * BigInteger.Pow(countSystem, power);
                power++;
                number /= 10;
            }

            Console.WriteLine(result);
        }
    }
}
