using System;
using System.Numerics;

namespace Big_Factorial
{
    class BigFactorial
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);    
        }
    }
}
