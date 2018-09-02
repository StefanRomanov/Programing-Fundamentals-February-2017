using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook_Upgrade
{
    class PhonebookUpgrade
    {
        public static void Main()
        {
            var phonebook = new SortedDictionary<string, string>();

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
                else if(command == "ListAll")
                {

                    foreach (var entry in phonebook)
                    {
                        Console.WriteLine($"{entry.Key} -> {entry.Value}");
                    }

                }
            }
        }
    }
}
