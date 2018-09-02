using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Valid_Usernames
{
    class ValidUsernames
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var usernames = new List<string>();
            var regex = new Regex("\\b[A-Za-z][\\w]{2,24}\\b");

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                usernames.Add(match.Value);
            }

            var maxSum = 0;
            var usernameTheFirst = string.Empty;
            var usernameTheSecond = string.Empty;

            for (int i = 0; i < usernames.Count - 1; i++)
            {
                var sum = usernames[i].Length + usernames[i + 1].Length;

                if (sum > maxSum)
                {
                    maxSum = sum;
                    usernameTheFirst = usernames[i];
                    usernameTheSecond = usernames[i + 1];
                }
            }

            Console.WriteLine(usernameTheFirst);
            Console.WriteLine(usernameTheSecond);
        }
    }
}