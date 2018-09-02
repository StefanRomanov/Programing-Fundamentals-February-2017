using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Cubic_Messages
{
    class Program
    {
        public static void Main()
        {
            var command = Console.ReadLine();

            while (command != "Over!")
            {
                var number = int.Parse(Console.ReadLine());
                var trueMessage = new Regex("^\\d+([A-Za-z]{" + number + "})[^A-Za-z]*$");
                var digit = new Regex("\\d+?");
                var digits = new List<int>();

                if (!trueMessage.IsMatch(command))
                {
                    command = Console.ReadLine();
                    continue;
                }
                var message = trueMessage.Match(command).Groups[1].ToString();
                var digitMatches = digit.Matches(command);

                foreach (Match item in digitMatches)
                {
                    digits.Add(int.Parse(item.ToString()));
                }

                var verificationCode = new StringBuilder();

                for (int i = 0; i < digits.Count; i++)
                {
                    if(digits[i] > message.Length - 1)
                    {
                        verificationCode.Append(" ");
                        continue;
                    }
                    verificationCode.Append(message[digits[i]]);
                }

                Console.WriteLine($"{message} == {verificationCode.ToString()}");

                command = Console.ReadLine();
            }
        }
    }
}