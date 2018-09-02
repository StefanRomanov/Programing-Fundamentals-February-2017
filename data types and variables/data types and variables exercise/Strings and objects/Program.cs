using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Hello ";
            string second = "World";
            object obj = first + second;
            string final = (string)obj;
            Console.WriteLine(final);
        }
    }
}
