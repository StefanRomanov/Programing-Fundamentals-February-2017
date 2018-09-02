using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());

            for (int checkedNumber = 2; checkedNumber <= userInput; checkedNumber++)

            {
                bool condition = true;

                for (int divider = 2; divider <= Math.Sqrt(checkedNumber); divider++)

            {

                    if (checkedNumber % divider == 0)

                    {

                        condition = false;

                        break;

                    }

                }

                Console.WriteLine($"{ checkedNumber} -> {condition}");

            }
        }
    }
}
