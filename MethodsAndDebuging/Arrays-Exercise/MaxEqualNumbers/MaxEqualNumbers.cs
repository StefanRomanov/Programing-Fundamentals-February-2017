using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string userInput = Console.ReadLine().Trim();

        var array = userInput.Split(' ').Select(int.Parse).ToArray();

        var length = 1;
        var bestLen = 0;
        var startNum = 0;
        var maxStart = 0;
        bool match = false;

        for (int i = 1; i < array.Length; i++)
        {

            if (array[i] == array[i - 1])
            {
                length++;
                match = true;
            }
            else
            {
                length = 1;
                startNum = i;
            }

            if (length > bestLen)
            {
                bestLen = length;
                maxStart = startNum;
            }
        }

        if (match == false)
        {
            maxStart = 0;
        }

        for (int start = 0; start < bestLen; start++)
        {
            Console.Write("{0} ", array[maxStart]);
        }
    }
}