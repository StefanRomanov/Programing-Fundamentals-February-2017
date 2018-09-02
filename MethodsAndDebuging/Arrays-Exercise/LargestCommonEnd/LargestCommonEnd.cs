using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string userInput1 = Console.ReadLine().Trim();
            string userInput2 = Console.ReadLine().Trim();

            var firstArray = userInput1.Split(' ').ToArray();
            var secondArray = userInput2.Split(' ').ToArray();

            int shorterLength = Math.Min(firstArray.Length, secondArray.Length);
            int frontCounter = 0;
            int backCounter = 0;

            for (int i = 0; i < shorterLength; i++)
            {
                if(firstArray[i] == secondArray[i])
                {
                    frontCounter++;
                }

                if (firstArray[firstArray.Length - i - 1] == secondArray[secondArray.Length - i - 1])
                {
                    backCounter++;
                }
            }

            Console.WriteLine($"{Math.Max(frontCounter, backCounter)}");
        }
    }
}
