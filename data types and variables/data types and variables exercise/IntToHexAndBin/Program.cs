using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntToHexAndBin
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(userInput, 16).ToUpper());

            Console.WriteLine(Convert.ToString(userInput, 2));

        }
    }
}
