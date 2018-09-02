using System;
using System.Linq;
using System.Collections.Generic;

public class SplitWordsByCasing
{
    public static void Main()
    {
        string userInput = Console.ReadLine().Trim();

        var separators = new char[]
        {
            ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' '
        };

        var firstList = userInput.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

        var allLower = new List<string>();
        var allUpper = new List<string>();
        var mixedCase = new List<string>();

        bool upper = false;
        bool lower = false;
        bool special = false;

        for (int i = 0; i < firstList.Count; i++)
        {

            foreach (char letter in firstList[i])
            {
                if (char.IsUpper(letter))
                {
                    upper = true;
                }
                else if (char.IsLower(letter))
                {
                    lower = true;
                }
                else
                {
                    special = true;
                }

            }

            if ((upper == true && lower == true) || special == true)
            {
                mixedCase.Add(firstList[i]);
            }
            else if (lower == true)
            {
                allLower.Add(firstList[i]);
            }
            else if (upper == true)
            {
                allUpper.Add(firstList[i]);
            }

            lower = false;
            upper = false;
            special = false;

        }

        Console.WriteLine("Lower-case: " + string.Join(", ", allLower));
        Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
        Console.WriteLine("Upper-case: " + string.Join(", ", allUpper));


    }
}
