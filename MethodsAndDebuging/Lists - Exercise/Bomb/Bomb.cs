using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb
{
    class Bomb
    {
        public static void Main()
        {
            string userInput = Console.ReadLine().Trim();

            string secondInput = Console.ReadLine().Trim();

            var numberList = userInput.Split(' ').Select(int.Parse).ToList();

            var bomb = secondInput.Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numberList.Count; i++)
            {

                if (numberList[i] == bomb[0])
                {

                    if (i - bomb[1] >= 0 && i + bomb[1] < numberList.Count)
                    {
                        numberList.RemoveRange(i - bomb[1], bomb[1] * 2 + 1);
                    }
                    else if (i - bomb[1] < 0)
                    {
                        numberList.RemoveRange(0, i + bomb[1] + 1);
                    }
                    else if (i + bomb[1] >= numberList.Count)
                    {
                        numberList.RemoveRange(i - bomb[1], bomb[1] + numberList.Count - i);
                    }

                    i = 0;
                }
            }

            Console.WriteLine(numberList.Sum());
        }
    }
}
