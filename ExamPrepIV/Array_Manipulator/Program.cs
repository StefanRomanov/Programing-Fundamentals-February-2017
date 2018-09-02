using System;
using System.Linq;

namespace Array_Manipulator
{
    class Program
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var command = Console.ReadLine();

            while (command != "end")
            {
                var instructions = command.Split().ToArray();
                var instruction = instructions[0];

                switch (instruction)
                {
                    case "exchange":
                        var index = int.Parse(instructions[1]);
                        array = Exchange(index, array);
                        break;
                    case "max":
                        var oddOrEven = instructions[1];
                        Max(array, oddOrEven);
                        break;
                    case "min":
                        oddOrEven = instructions[1];
                        Min(array, oddOrEven);
                        break;
                    case "first":
                        oddOrEven = instructions[2];
                        var count = int.Parse(instructions[1]);
                        First(array, count, oddOrEven);
                        break;
                    case "last":
                        oddOrEven = instructions[2];
                        count = int.Parse(instructions[1]);
                        Last(array, count, oddOrEven);
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        public static int[] Exchange(int index, int[] array)
        {
            if (index > array.Length - 1 || index < 0)
            {
                Console.WriteLine("Invalid index");
                return array;
            }

            var result = array.Skip(index + 1).Concat(array.Take(index + 1)).ToArray();
            return result;
        }

        public static void Max(int[] array, string oddOrEven)
        {
            var remainder = 0;
            if (oddOrEven == "odd")
            {
                remainder = 1;
            }
            var evenOrOddArray = array.Where(x => x % 2 == remainder).ToArray();
            if (evenOrOddArray.Length == 0)
            {
                Console.WriteLine("No matches");
                return;
            }
            Console.WriteLine(Array.LastIndexOf(array, evenOrOddArray.Max()));
        }

        public static void Min(int[] array, string oddOrEven)
        {
            var remainder = 0;
            if (oddOrEven == "odd")
            {
                remainder = 1;
            }
            var evenOrOddArray = array.Where(x => x % 2 == remainder).ToArray();
            if (evenOrOddArray.Length == 0)
            {
                Console.WriteLine("No matches");
                return;
            }
            Console.WriteLine(Array.LastIndexOf(array, evenOrOddArray.Min()));
        }

        public static void First(int[] array, int count, string oddOrEven)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            var reminder = 0;
            if (oddOrEven == "odd")
            {
                reminder = 1;
            }

            var resut = array.Where(x => x % 2 == reminder).Take(count).ToArray();
            if (resut.Length == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ",resut)}]");
            }
        }

        public static void Last(int[] array, int count, string oddOrEven)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            var reminder = 0;
            if (oddOrEven == "odd")
            {
                reminder = 1;
            }

            var resut = array.Where(x => x % 2 == reminder).Reverse().Take(count).Reverse().ToArray();
            if (resut.Length == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", resut)}]");
            }
        }
    }
}