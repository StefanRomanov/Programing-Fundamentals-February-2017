using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrays
{
    class CondenseArrays
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine().Trim();

            var array = userInput.Split(' ').Select(long.Parse).ToArray();

            while (array.Length > 1)
            {
                var condensedArray = new long[array.Length - 1];

                for (int i = 0; i < condensedArray.Length; i++)
                {
                    condensedArray[i] = array[i] + array[i + 1];
                }

                array = condensedArray;
            }
            Console.WriteLine(array[0]);
        }
    }
}
