using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativeAndReverse
{
    class RemoveNegativeAndReverse
    {
        public static void Main()
        {
            string userInput = Console.ReadLine().Trim();

            var firstList = userInput.Split(' ').Select(int.Parse).ToList();

            var secondList = new List<int>();

            for (int i = 0; i < firstList.Count; i++)
            {

                if (firstList[i] > 0)
                {
                    secondList.Add(firstList[i]);
                }

            }

            secondList.Reverse();

            string result = string.Join(" ", secondList);

            if (result == string.Empty)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
