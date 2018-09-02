using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine().Trim();

            var array = userInput.Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                double holder = 0.0;
                holder = array[i];
                array[i] = Math.Round(array[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{holder} => {array[i]}");
            }   
        }
    }
}
