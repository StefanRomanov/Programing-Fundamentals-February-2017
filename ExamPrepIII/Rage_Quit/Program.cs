using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Rage_Quit
{
    class Program
    {
        public static void Main()
        {
            var rageFormat = new Regex("([^\\d]+)(\\d+)");
            var input = Console.ReadLine();

            var result = new StringBuilder();

            var matches = rageFormat.Matches(input);

            foreach (Match component in matches)
            {
                var message = component.Groups[1].ToString();
                var count = int.Parse(component.Groups[2].ToString());

                for (int i = 0; i < count; i++)
                {
                    result.Append(message.ToUpper());
                }
            }

            var output = result.ToString();
            var uniqueCounter = output.ToCharArray().Distinct().ToArray();

            Console.WriteLine($"Unique symbols used: {uniqueCounter.Length}");
            Console.WriteLine(output);
        }
    }
}