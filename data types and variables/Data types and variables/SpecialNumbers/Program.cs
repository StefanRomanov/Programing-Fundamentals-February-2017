using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= userInput; i++)
            {
                var number = i;
                var digitSum = 0;
                while (number > 0)
                { 
                    var digit = number % 10;
                    number = number / 10;
                    digitSum += digit;
                }
                bool condition = ((digitSum == 5) || (digitSum == 11) || (digitSum == 7));
                Console.WriteLine($"{i} -> {condition}");
            }
        }
    }
}
