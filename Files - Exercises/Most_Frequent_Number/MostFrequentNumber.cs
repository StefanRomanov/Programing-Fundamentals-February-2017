using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Most_Frequent_Number
{
    class MostFrequentNumber
    {
        public static void Main()
        {
            var input = File.ReadAllText("input.txt").Split().Select(int.Parse).ToArray();

            var maxMatches = 0;
            var currentMatches = 1;
            var maxPosition = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        currentMatches++;
                    }

                    if (currentMatches > maxMatches)
                    {
                        maxMatches = currentMatches;
                        maxPosition = i;
                    }
                }
                currentMatches = 1;
            }

            var result = input[maxPosition].ToString();

            File.WriteAllText("output.txt", result);

            Console.WriteLine(File.ReadAllText("output.txt"));
        }
    }
}
