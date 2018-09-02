using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseIntArray
{
    class ReverseIntArray
    {
        static void Main(string[] args)
        {
            int arrayLenght = int.Parse(Console.ReadLine());

            int[] originalArray = new int[arrayLenght];

            var reversedArray = new int[originalArray.Length];

            for (int i = 0; i < originalArray.Length; i++)
            {
                int userNumber = int.Parse(Console.ReadLine());

                originalArray[i] = userNumber;

                reversedArray[reversedArray.Length - 1 - i] = originalArray[i];
            }

            Console.WriteLine(string.Join(" ", reversedArray));

        }
    }
}
