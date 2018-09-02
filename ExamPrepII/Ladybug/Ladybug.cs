using System;
using System.Linq;

namespace Ladybug
{
    class Ladybug
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var indexes = Console.ReadLine()
                    .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            var field = FieldStructure(fieldSize, indexes);

            var command = Console.ReadLine();

            while (command != "end")
            {
                var commandParts = command.Split().ToArray();
                var ladybugIndex = long.Parse(commandParts[0]);
                var direction = commandParts[1];
                var jumpLength = int.Parse(commandParts[2]);
                
                if (!(ladybugIndex > fieldSize - 1 || ladybugIndex < 0 || field[ladybugIndex] == 0))
                {
                    field[ladybugIndex] = 0;

                    while (true)
                    {
                        if (direction == "left" && ladybugIndex - jumpLength >= 0)
                        {
                            ladybugIndex -= jumpLength;
                        }
                        else if (direction == "right" && ladybugIndex + jumpLength < fieldSize)
                        {
                            ladybugIndex += jumpLength;
                        }
                        else
                        {
                            break;
                        }

                        if (field[ladybugIndex] == 0)
                        {
                            field[ladybugIndex] = 1;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }

        public static int[] FieldStructure(int size, int[] indexes)
        {
            var field = new int[size];

            for (int i = 0; i < size; i++)
            {
                if (indexes.Contains(i))
                {
                    field[i] = 1;
                }
                else
                {
                    field[i] = 0;
                }
            }
            return field;
        }
    }
}