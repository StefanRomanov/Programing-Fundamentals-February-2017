using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        public static void Main(string[] args)
        {
            string userInput = Console.ReadLine().Trim();

            var array = userInput.Split(' ').Select(int.Parse).ToArray();
            bool match = false;

            for (int i = 0; i < array.Length; i++)
            {
                var frontSums = SumFront(array, i);
                var backSum = SumBack(array, i);

                if(frontSums == backSum)
                {
                   Console.WriteLine(i);
                    match = true;
                }

            }

            if (match == false)
            {
                Console.WriteLine("no");
            }

        }

        public static int SumFront(int[] array, int midPoint)
        {
            var sum = 0;

            for (int i = 0; i < midPoint; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        public static int SumBack(int[] array, int midPoint)
        {
            var sum = 0;

            for (int i = array.Length - 1; i > midPoint; i--)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}
