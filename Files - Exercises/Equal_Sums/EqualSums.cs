using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Equal_Sums
{
    class EqualSums
    {
        public static void Main()
        {
            var input = File.ReadAllText("input.txt").Split().Select(int.Parse).ToList();

            var frontSum = 0;
            var backSum = 0;
            var result = "no";

            for (int i = 0; i < input.Count; i++)
            {
                frontSum = input.Take(i).Sum();
                backSum = input.Skip(i + 1).Take(input.Count - i).Sum();

                if (backSum == frontSum)
                {
                    result = i.ToString();
                }
            }

            File.WriteAllText("output.txt", result);
        }
    }
}
