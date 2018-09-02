using System;
using System.Linq;
using System.Collections.Generic;

public class SumAdjacentNumbers
{
    public static void Main()
    {
        string userInput = Console.ReadLine().Trim();

        var firstList = userInput.Split(' ').Select(decimal.Parse).ToList();

        var result = new List<decimal>();

        for (int i = 0; i < Math.Sqrt(firstList.Count); i++)
        {
            firstList = CondenseList(firstList);
            result = CondenseList(firstList);

        }

        foreach (var number in result)
        {
            Console.WriteLine("{0} ", number);
        }
    }

    public static List<decimal> CondenseList(List<decimal> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i] == list[i + 1])
            {
                list[i] = list[i] + list[i + 1];
                list.Remove(list[i + 1]);
            }
        }

        return list;
    }
}
