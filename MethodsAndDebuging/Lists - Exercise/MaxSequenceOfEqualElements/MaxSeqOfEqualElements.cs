using System;
using System.Collections.Generic;
using System.Linq;


namespace MaxSequenceOfEqualElements
{
    class MaxSeqOfEqualElements
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine().Trim();

            var numberList = userInput.Split(' ').Select(int.Parse).ToList();

            var count = 1;
            var bestCount = 0;
            var position = 0;
            var bestPosition = 0;

            for (int i = 1; i < numberList.Count; i++)
            {
                if (numberList[i - 1] == numberList[i])
                {
                    position = i;
                    count++;
                }
                else
                {
                    count = 1;
                }

                if(bestCount < count)
                {
                    bestCount = count;
                    bestPosition = position;
                }
            }

            for (int i = 0; i < bestCount; i++)
            {
                Console.Write($"{numberList[bestPosition]} ");
            }

        }
    }
}
