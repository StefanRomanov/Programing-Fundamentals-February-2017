using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers
{
    class CountNumbers
    {
        public static void Main()
        {
            string userInput = Console.ReadLine().Trim();

            var numberList = userInput.Split(' ').Select(int.Parse).ToList();

            numberList.Sort();

            var counter = 1;

            for (int i = 0; i < numberList.Count; i++)
            {

                if (i + 1 < numberList.Count && numberList[i] == numberList[i + 1])
                {

                    counter++;

                }
                else
                {

                    Console.WriteLine($"{numberList[i]} -> {counter}");
                    counter = 1;

                }
            }
        }
    }
}
