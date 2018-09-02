using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Use_Your_Chains
{
    class Chains
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var spaces = new Regex("[^a-z\\d]+");
            var pattern = new Regex("(?<=<p>)(.*?)(?=<\\/p>)");

            var instructions = pattern.Matches(text);
            var result = new StringBuilder();

            foreach (Match item in instructions)
            {
                var instruction = spaces.Replace(item.Value, " ");

                for (int i = 0; i < instruction.Length; i++)
                {

                    if (instruction[i] >= 'a' && instruction[i] <= 'm' && instruction[i] != ' ')
                    {
                        result.Append((char)(instruction[i] + 13));
                    }
                    else if(instruction[i] >= 'n' && instruction[i] <= 'z' && instruction[i] != ' ')
                    {
                        result.Append((char)(instruction[i] - 13));
                    }
                    else
                    {
                        result.Append(instruction[i]);
                    }

                }
            }

            var output = result.ToString();
            Console.WriteLine(output);
        }
    }
}