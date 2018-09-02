using System;
using System.Linq;
using System.Collections.Generic;

public class SquareNumbers
{
    public static void Main()
    {
        string userInput = Console.ReadLine().Trim();

        var firstList = userInput.Split(' ').Select(int.Parse).ToList();

        var result = new List<int>();

        for (int i = 0; i < firstList.Count; i++)
        {

            if (Math.Sqrt(firstList[i]) % 1 == 0)
            {
                result.Add(firstList[i]);
            }

        }

        result.Sort((a, b) => b.CompareTo(a));

        Console.WriteLine(string.Join(" ", result));
    }
}
