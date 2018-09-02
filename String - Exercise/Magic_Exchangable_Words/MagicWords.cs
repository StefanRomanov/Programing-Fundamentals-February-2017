using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magic_Exchangable_Words
{
    class MagicWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();

            var firstString = input[0];
            var secondString = input[1];

            var min = Math.Min(firstString.Length, secondString.Length);

            var firstLen = firstString.ToCharArray().Distinct().Count();
            var secondLen =secondString.ToCharArray().Distinct().Count();

            if (firstLen != secondLen)
            {
                Console.WriteLine("false");
            }
            else
            {
                for (int i = 1; i < min; i++)
                {
                    if ((firstString[i] == firstString[i -1]) != (secondString[i] == secondString[i - 1]))
                    {
                        Console.WriteLine("false");
                        break;
                    }
                }
                Console.WriteLine("true");
            }
        }
    }
}