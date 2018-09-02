using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeInts
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());

            var secondNumber = int.Parse(Console.ReadLine());

            var placeHolder = firstNumber;

            Console.WriteLine($"Before: \n a = {firstNumber} \n b = {secondNumber}");
            firstNumber = secondNumber;

            secondNumber = placeHolder;
            Console.WriteLine($"After: \n a = {firstNumber} \n b = {secondNumber}");
        }
    }
}
