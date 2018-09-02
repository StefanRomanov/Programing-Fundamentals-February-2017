using System;
using System.Text;

namespace Sum_Big_Numbers
{
    class SumBigNumbers
    {
        public static void Main()
        {
            var firstNum = Console.ReadLine().TrimStart('0');
            var secondNum = Console.ReadLine().TrimStart('0');

            if (firstNum.Length > secondNum.Length)
            {
                secondNum = secondNum.PadLeft(firstNum.Length, '0');
            }
            else
            {
                firstNum = firstNum.PadLeft(secondNum.Length, '0');
            }

            var length = firstNum.Length;
            var remainder = 0;
            var lastDigit = string.Empty;
            var result = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                var lastDigitFirst = firstNum[firstNum.Length - 1].ToString();
                var lastDigitSecond = secondNum[secondNum.Length - 1].ToString();
                var sum = int.Parse(lastDigitFirst) + int.Parse(lastDigitSecond) + remainder;
                remainder = sum / 10;
                lastDigit = (sum % 10).ToString();

                firstNum = firstNum.Remove(firstNum.Length - 1, 1);
                secondNum = secondNum.Remove(secondNum.Length - 1, 1);

                result = result.Insert(0, lastDigit);
            }

            if (remainder == 1 && firstNum.Length == secondNum.Length)
            {
                result = result.Insert(0, remainder.ToString());
            }

            Console.WriteLine(result);
        }
    }
}