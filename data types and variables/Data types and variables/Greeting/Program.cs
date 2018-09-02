using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var secondName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {firstName} {secondName}.\r\nYou are {age} years old.");
        }
    }
}
