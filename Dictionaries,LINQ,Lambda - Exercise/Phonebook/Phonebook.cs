using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    class Phonebook
    {
        public static void Main()
        {
            var phonebook = new Dictionary<string, string>();

            var command = string.Empty;

            while (command != "END")
            {
                var userInput = Console.ReadLine()
                .Split(' ')
                .ToArray();

                command = userInput[0];
                 
                if (command == "A")
                {
                    phonebook[userInput[1]] = userInput[2];
                }
                else if (command == "S")
                {

                    if (phonebook.ContainsKey(userInput[1]))
                    {
                        Console.WriteLine($"{userInput[1]} -> {phonebook[userInput[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {userInput[1]} does not exist.");
                    }

                }
            }
        }
    }
}
