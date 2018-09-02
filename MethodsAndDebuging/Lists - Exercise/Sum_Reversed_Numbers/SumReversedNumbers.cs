using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Reversed_Numbers
{
    class SumReversedNumbers
    {
        public static void Main()
        {
            string userInput = Console.ReadLine().Trim();

            var firstList = userInput.Split(' ').ToArray();

            var finalList = new List<int>();

            for (int i = 0; i < firstList.Length; i++)
            {
                finalList.Add(ReverseNumber(firstList, i));
            }
            
            Console.WriteLine(finalList.Sum());
        }

        public static int ReverseNumber(string[] array, int index)
        {
            var tempList = array[index].ToList();

            tempList.Reverse();

            var result = string.Join("", tempList);

            return int.Parse(result);
        }

    }
}
