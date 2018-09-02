using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine().Trim();

            var array = userInput.Split(' ').Select(int.Parse).ToArray();

            var counter = 1;
            var topCounter = 0;
            var currentNumber = 0;
            var topNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {

                    if (array[i] == array[j])
                    {
                        counter++;
                        currentNumber = i;
                    }

                    if (counter > topCounter)
                    {
                        topCounter = counter;
                        topNumber = currentNumber;
                    }        
                }
                counter = 0;
            }

            Console.WriteLine(array[topNumber]);
        }
    }
}
