using System;
using System.Linq;

namespace Command_Interpreter
{
    class CommandInterpreter
    {
        public static void Main()
        {
            var data = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var command = Console.ReadLine();

            while (command != "end")
            {
                var commandParts = command.Split().ToArray();
                if (commandParts[0] == "reverse")
                {
                    try
                    {
                        var startIndex = int.Parse(commandParts[2]);
                        var count = int.Parse(commandParts[4]);
                        data.Reverse(startIndex, count);
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (commandParts[0] == "sort")
                {
                    try
                    {
                        var startIndex = int.Parse(commandParts[2]);
                        var count = int.Parse(commandParts[4]);
                        data.Sort(startIndex, count, StringComparer.InvariantCulture);
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (commandParts[0] == "rollLeft")
                {
                    var count = int.Parse(commandParts[1]) % data.Count;

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine();
                        continue;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        var firstElement = data[0];
                        data.Add(firstElement);
                        data.RemoveAt(0);
                    }

                }
                else if (commandParts[0] == "rollRight")
                {
                    var count = int.Parse(commandParts[1]) % data.Count;

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine();
                        continue;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        var lastElement = data[data.Count - 1];
                        data.Insert(0, lastElement);
                        data.RemoveAt(data.Count - 1);
                    }

                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", data) + "]");
        }
    }
}
