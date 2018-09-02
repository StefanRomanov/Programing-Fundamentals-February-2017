using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine().Trim();
            string input2 = Console.ReadLine().Trim();

            var firstArray = input1.Split(' ').Select(char.Parse).ToArray();
            var secondArray = input2.Split(' ').Select(char.Parse).ToArray();

            bool firstSmaller = false;
            bool secondSmaller = false;


            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {

                if (firstArray[i] != secondArray[i])
                {

                    if (firstArray[i] < secondArray[i])
                    {
                        firstSmaller = true;
                    }
                    else
                    {
                        secondSmaller = true;
                    }
                    break;
                }

            }

            if (firstSmaller == false && secondSmaller == false)
            {
                if (firstArray.Length < secondArray.Length)
                {
                    firstSmaller = true;
                }
                else
                {
                    secondSmaller = true;
                }
            }

            if (firstSmaller == true)
            {
                PrintAlphabetically(firstArray, secondArray);
            }
            else
            {
                PrintAlphabetically(secondArray, firstArray);
            }
        }

        public static void PrintAlphabetically(char[] first, char[] second)
        {
            var firstString = new string(first);
            var secondString = new string(second);

            var result = firstString + "\n" + secondString;

            Console.WriteLine( result);
        }
    }
}
