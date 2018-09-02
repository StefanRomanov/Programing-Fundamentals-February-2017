using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine().Trim();
            int difference = int.Parse(Console.ReadLine());

            var array = userInput.Split(' ').Select(int.Parse).ToArray();

            var matches = 0;

            for (int i = 0; i < array.Length; i++)
            {

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (Math.Max(array[i],array[j]) - Math.Min(array[i],array[j]) == difference)
                    {
                        matches++;
                    }
                }

            }

            Console.WriteLine(matches);
        }
    }
}
