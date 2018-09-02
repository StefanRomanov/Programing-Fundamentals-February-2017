using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Fix_Emails
{
    class FixEmails
    {
        public static void Main()
        {
            var input = File.ReadAllLines("input.txt");

            var usersAndEmails = new Dictionary<string, string>();
            var name = string.Empty;
            var email = string.Empty;
            var output = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                var command = input[i].ToLower();

                if (command != "stop")
                {

                    if (i % 2 == 0 && (!input[i + 1].EndsWith("uk") && !input[i + 1].EndsWith("us")))
                    {
                        name = command;

                        if (!usersAndEmails.ContainsKey(command))
                        {
                            usersAndEmails.Add(name, email);
                        }

                    }
                    if (i % 2 != 0 && !command.EndsWith("uk") && !command.EndsWith("us"))
                    {
                        email = input[i];

                        usersAndEmails[name] = email;
                    }
                    
                }
            }

            foreach (var entry in usersAndEmails)
            {
                output.Add($"{entry.Key} -> {entry.Value}");
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}
