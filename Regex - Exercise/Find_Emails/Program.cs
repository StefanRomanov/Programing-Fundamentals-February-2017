using System;
using System.Text.RegularExpressions;

namespace Find_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();

            var regex = new Regex(@"\b(?<!\.|\-)([A-Za-z\d][\dA-z.-]+@[A-Za-z-]+\.[A-Za-z-.]+[A-Za-z])(?!\-)\b");

            while (command != "end")
            {
                var matches = regex.Matches(command);

                foreach (Match item in matches)
                {
                    Console.WriteLine(item.Groups[1]);
                }

                command = Console.ReadLine();
            }
        }
    }
}
