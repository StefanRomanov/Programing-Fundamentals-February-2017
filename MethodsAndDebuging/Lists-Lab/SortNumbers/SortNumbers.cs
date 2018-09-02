using System;
using System.Linq;

public class SortNumbers
{
    public static void Main()
    {
        string userInput = Console.ReadLine().Trim();

        var firstList = userInput.Split(' ').Select(decimal.Parse).ToList();

        firstList.Sort();

        Console.WriteLine(string.Join(" ", firstList));
    }
}