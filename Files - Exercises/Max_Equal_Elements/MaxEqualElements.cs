using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Max_Equal_Elements
{
    class MaxEqualElements
    {
        public static void Main()
        {
            var input = File.ReadAllText("input.txt").Split().Select(int.Parse).ToArray();

            var length = 1;
            var maxLength = 0;
            var currentNumber = 0;
            var maxNumber = 0;
            var result = new List<int>();

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    currentNumber = i;

                    if (input[i] == input[j])
                    {
                        length++;
                    }

                    if (length > maxLength)
                    {
                        maxNumber = currentNumber;
                        maxLength = length;
                    }
                }
                length = 1;
            }

            for (int i = 0; i < maxLength; i++)
            {
                result.Add(input[maxNumber]);
            }

            var output = string.Join(" ", result);

            File.WriteAllText("output.txt", output);
        }
    }
}
