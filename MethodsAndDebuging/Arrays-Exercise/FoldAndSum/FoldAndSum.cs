using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine().Trim();

            var originalArray = userInput.Split(' ').Select(int.Parse).ToArray();

            var foldFrontArray = FoldAndReverseFront(originalArray);

            var foldBackArray = FoldAndReverseBack(originalArray);

            var mainArray = TrimArray(originalArray);

            var result = SumArrays(mainArray, foldFrontArray, foldBackArray);

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }

        public static int[] FoldAndReverseFront(int[] array)
        {
            var foldedArray = new int[array.Length / 4];

            for (int i = 0; i < array.Length/4; i++)
            {
                foldedArray[i] = array[array.Length/4 - i -1];
            }

            return foldedArray;
        }

        public static int[] FoldAndReverseBack(int[] array)
        {
            var foldedArray = new int[array.Length / 4];

            for (int i = 0; i < array.Length / 4; i++)
            {
                foldedArray[i] = array[array.Length - i - 1];
            }

            return foldedArray;
        }

        public static int[] TrimArray(int[] array)
        {
            var trimmedArray = new int[array.Length / 2];

            for (int i = 0; i < array.Length/2; i++)
            {
                trimmedArray[i] = array[array.Length / 4 + i];
            }

            return trimmedArray;
        }

        public static int[] SumArrays(int[] mainArray, int[] foldFront, int[] foldBack)
        {

            for (int i = 0; i < mainArray.Length/2; i++)
            {
                mainArray[i] += foldFront[i];
                mainArray[mainArray.Length - i - 1] += foldBack[foldBack.Length - i - 1];
            }

            return mainArray;
        }
    }
}
