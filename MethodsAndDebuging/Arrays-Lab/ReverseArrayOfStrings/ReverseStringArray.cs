using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfStrings
{
    class ReverseStringArray
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine().Trim();

            var array = userInput.Split(' ').ToArray();

            for (int i = 0; i < array.Length/2; i++)
            {
                string holder = string.Empty;
                holder = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = holder;
            }

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
