using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSumArrays
{
    class RotateAndSumArray
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine().Trim();
            int rotate = int.Parse(Console.ReadLine());

            var firstArray = userInput.Split(' ').Select(int.Parse).ToArray();

            var shiftedArray = new int[firstArray.Length];

            var resultArray = new int[firstArray.Length];

            for (int i = 1; i <= rotate; i++)
            {
                shiftedArray = RotateArrayRight(firstArray);

                for (int j = 0; j < firstArray.Length; j++)
                {

                    resultArray[j] += shiftedArray[j];
                }

                firstArray = shiftedArray;
            }

            foreach (int number in resultArray)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();
        }

        public static int[] RotateArrayRight(int[] array)
        {
            int holder = array[array.Length - 1];

            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = holder;

            return array;
        }
    }
}
