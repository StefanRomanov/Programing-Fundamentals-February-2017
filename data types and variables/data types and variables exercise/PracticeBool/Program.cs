using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBool
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = Convert.ToBoolean(Console.ReadLine());
            if (userInput == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
