using System;

namespace Multiply_Big_Numbers
{
    class MultiplyBigNumbers
    {
        public static void Main()
        {
            var number = Console.ReadLine().TrimStart('0');
            var secondNumber = Console.ReadLine();

            var inMind = 0;
            var digit = string.Empty;
            var lenght = number.Length;
            var result = string.Empty;

            for (int i = 0; i < lenght; i++)
            {
                var lastDigit = int.Parse(number[number.Length - 1].ToString());
                var multiplier = int.Parse(secondNumber);

                var sum = lastDigit * multiplier + inMind;
                digit = (sum % 10).ToString();
                inMind = sum / 10;

                number = number.Remove(number.Length - 1, 1);

                result = result.Insert(0, digit);
            }

            if (inMind > 0)
            {
                result = result.Insert(0, inMind.ToString());
            }

            result = result.TrimStart('0');

            if (result.Length == 0)
            {
                Console.WriteLine('0');
                return;
            }

            Console.WriteLine(result);
        }
    }
}