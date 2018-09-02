using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrippleSum
{
    class TrippleSum
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine().Trim();

            var array = userInput.Split(' ').Select(int.Parse).ToArray();

            bool match = false;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    for (int k = 0; k < array.Length; k++)
                    {

                        if (array[i] + array[j] == array[k])
                        {
                            Console.WriteLine($"{array[i]} + {array[j]} == {array[k]}");

                            match = true;
                            break;
                        }

                    }
                }
            }
            if (match == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
