using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Letters_Change_Numbers
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var sum = 0.0d;

            foreach (var entry in input)
            {
                var firstLetter = entry.First();
                double number = double.Parse(entry.Substring(1, entry.Length - 2));
                var secondLetter = entry.Last();

                if (char.IsLower(firstLetter))
                {
                    number *= (int)(firstLetter - 'a' + 1);
                }
                else
                {
                    number /= (int)(firstLetter - 'A' + 1);
                }

                if (char.IsLower(secondLetter))
                {
                    number += (int)(secondLetter - 'a' + 1);
                }
                else
                {
                    number -= (int)(secondLetter - 'A' + 1);
                }

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}