using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentSizeInts
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            string output = $"{userInput} can fit in:\n";
            bool errorCheck = true;

            try
            {
                sbyte num = sbyte.Parse(userInput);
                output += "* sbyte\n";
            }
            catch 
            {

            }
            try
            {
                byte num = byte.Parse(userInput);
                output += "* byte\n";
            }
            catch 
            {

            }
            try
            {
                short num = short.Parse(userInput);
                output += "* short\n";
            }
            catch
            {

            }
            try
            {
                ushort num = ushort.Parse(userInput);
                output += "* ushort\n";
            }
            catch
            {

            }
            try
            {
                int num = int.Parse(userInput);
                output += "* int\n";
            }
            catch
            {

            }
            try
            {
                uint num = uint.Parse(userInput);
                output += "* uint\n";
            }
            catch 
            {

            }
            try
            {
                long num = long.Parse(userInput);
                output += "* long\n";
            }
            catch
            {
                errorCheck = false;
            }
            if (errorCheck)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine($"{userInput} can't fit in any type");
            }
        }
    }
}
