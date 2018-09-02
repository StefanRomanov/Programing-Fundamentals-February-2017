using System;
using System.Linq;
using System.Collections.Generic;

public class AppendList
{
    public static void Main()
    {
        string userInput = Console.ReadLine().Trim();

        var array = userInput.Split('|').ToArray();

        var list = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {

            var tempArray = array[array.Length - i - 1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            list.AddRange(tempArray);

        }

        foreach (var number in list)
        {
            Console.Write("{0} ", number);
        }
    }
}