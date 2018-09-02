using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrippleOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            for (int firstLetter = 0; firstLetter < num; firstLetter++)
            {
                for (int secondLetter = 0; secondLetter < num; secondLetter++)
                {
                    for (int thirdLetter = 0; thirdLetter < num; thirdLetter++)
                    {
                        char first = (char)('a' + firstLetter);
                        char second = (char)('a' + secondLetter);
                        char third = (char)('a' + thirdLetter);
                        Console.WriteLine("{0}{1}{2}",first,second,third);
                    }
                }
            }
        }
    }
}
