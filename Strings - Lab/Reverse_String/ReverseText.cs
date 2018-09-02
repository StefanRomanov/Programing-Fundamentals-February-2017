using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse_String
{
    class ReverseText
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var result = input.ToCharArray().Reverse().ToArray();

            var output = string.Join("", result);

            Console.WriteLine(output);
        }
    }
}
