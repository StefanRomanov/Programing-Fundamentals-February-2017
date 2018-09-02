using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        public static void Main(string[] args)
        {
            string userInput = Console.ReadLine().Trim();

            var array = userInput.Split(' ').Select(int.Parse).ToArray();

            var result = PrintMiddleOfArray(array);

            Console.WriteLine(result);
        }

        public static string PrintMiddleOfArray(int[] array)
        {
            var middle = string.Empty;

            if (array.Length == 1)
            {
               middle = $"{{ {array[0]} }}";
            }
            else if (array.Length % 2 == 0)
            {
                middle = $"{{ {array[array.Length / 2 - 1 ]}, {array[array.Length / 2] } }}";
            }
            else if (array.Length % 2 != 0)
            {
                middle = $"{{ {array[array.Length / 2 - 1]}, {array[array.Length / 2]}, {array[array.Length / 2 + 1]} }}";
            }
            return middle;
        }
    }
}
