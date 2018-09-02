using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            string userInput1 = Console.ReadLine().Trim();
            string userInput2 = Console.ReadLine().Trim();

            var firstArray = userInput1.Split(' ').Select(int.Parse).ToArray();
            var secondArray = userInput2.Split(' ').Select(int.Parse).ToArray();

            int[] result = new int[Math.Max(firstArray.Length, secondArray.Length)];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
            }

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
