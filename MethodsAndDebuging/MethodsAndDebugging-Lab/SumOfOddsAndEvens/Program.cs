using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddsAndEvens
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber = int.Parse(Console.ReadLine());

            int sumOdds = SumOfOddsOrEvens(Math.Abs(userNumber) ,1);
            int sumEvens = SumOfOddsOrEvens(Math.Abs(userNumber), 0);

            int result = sumEvens * sumOdds;

            Console.WriteLine(result);
        }
        public static int SumOfOddsOrEvens(int number, int remainder)
        {
            int sumOdds = 0;
            while (number > 0)
            {
                int digit = number % 10;
                number = number/10;
                sumOdds += OddOrEven(digit,remainder);
            }
            return sumOdds;

        }
        public static int OddOrEven(int digit, int remainder)
        {

            if (digit % 2 == remainder)
            {
                return digit;
            }

            else
            {
                return 0;
            }
        }
    }
}
