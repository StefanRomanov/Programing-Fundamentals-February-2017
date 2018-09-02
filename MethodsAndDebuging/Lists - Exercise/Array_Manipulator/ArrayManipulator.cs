using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string userArray = Console.ReadLine().Trim();

        var numberList = userArray.Split(' ').Select(int.Parse).ToList();

        var command = string.Empty;

        while (command != "print")
        {

            var commandList = Console.ReadLine().Trim().Split(' ').ToList();

            command = commandList[0];

            switch (command)
            {
                case "add":
                    numberList = CommandAdd(numberList, commandList);
                    break;

                case "addMany":
                    numberList = CommandAddMany(numberList, commandList);
                    break;

                case "contains":
                    Console.WriteLine(CommandContains(numberList, int.Parse(commandList[1])));
                    break;

                case "remove":
                    numberList = CommandRemove(numberList, commandList);
                    break;

                case "shift":
                    numberList = CommandShift(numberList, int.Parse(commandList[1]));
                    break;

                case "sumPairs":
                    numberList = CommandSumPairs(numberList);
                    break;

            }
        }

        Console.WriteLine("[" + string.Join(", ", numberList) + "]");

    }

    public static List<int> CommandAdd(List<int> numbersList, List<string> commandList)
    {
        var index = int.Parse(commandList[1]);
        var number = int.Parse(commandList[2]);

        numbersList.Insert(index, number);

        return numbersList;
    }

    public static List<int> CommandAddMany(List<int> numbersList, List<string> commandList)
    {

        for (int i = commandList.Count - 1; i > 1; i--)
        {
            numbersList.Insert(int.Parse(commandList[1]), int.Parse(commandList[i]));
        }

        return numbersList;
    }

    public static int CommandContains(List<int> numbersList, int commandNumber)
    {
        int result = -1;

        if(numbersList.Contains(commandNumber))
        {
            result = numbersList.IndexOf(commandNumber);

        }

        return result;
    }

    public static List<int> CommandRemove(List<int> numbersList, List<string> commandList)
    {
        if (int.Parse(commandList[1]) <= numbersList.Count - 1)
        {
            numbersList.RemoveAt(int.Parse(commandList[1]));
        }

        return numbersList;

    }

    public static List<int> CommandShift(List<int> numbersList, int shiftTimes)
    {

        for (int i = 0; i < shiftTimes; i++)
        {
            var temp = numbersList[0];

            for (int j = 0; j < numbersList.Count - 1; j++)
            {
                numbersList[j] = numbersList[j + 1];
            }

            numbersList[numbersList.Count - 1] = temp;
        }

        return numbersList;
    }

    public static List<int> CommandSumPairs(List<int> numbersList)
    {

        for (int i = 0; i < numbersList.Count - 1; i++)
        {
            numbersList[i] = numbersList[i] + numbersList[i + 1];
            numbersList.RemoveAt(i + 1);
        }

        return numbersList;
    }
}
