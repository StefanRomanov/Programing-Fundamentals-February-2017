using System;
using System.Collections.Generic;
using System.Linq;

namespace User_Logs
{
    class UserLogs
    {
        public static void Main()
        {
            var userRegister = new Dictionary<string, string>();

            var finalRegister = new SortedDictionary<string, Dictionary<string, int>>();

            var name = string.Empty;

            while (name != "end")
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var ipAdress = string.Empty;

                name = input[input.Count - 1];

                if (name != "end")
                {
                    ipAdress = input[1];

                    if (!userRegister.ContainsKey(name))
                    {
                        userRegister.Add(name, ipAdress);
                    }
                    else
                    {
                        userRegister[name] += " " + ipAdress;
                    }
                }
            }

            foreach (var record in userRegister)
            {
                finalRegister[record.Key] = IPAdressRegister(record.Value);
            }

            foreach (var item in finalRegister)
            {
                Console.WriteLine($"{item.Key}: ");

                foreach (var record in item.Value)
                {
                    var last = item.Value.Keys.Last();

                    if (record.Key == last)
                    {
                        Console.WriteLine($"{record.Key} => {record.Value}.");
                    }
                    else
                    {
                        Console.Write($"{record.Key} => {record.Value}, ");
                    }
                }
            }

        }

        public static Dictionary<string, int> IPAdressRegister(string ipAdresses)
        {
            var ipAdressRegister = new Dictionary<string, int>();

            var ipList = ipAdresses
                .Split(' ')
                .ToList();

            foreach (var IP in ipList)
            {
                if (!ipAdressRegister.ContainsKey(IP))
                {
                    ipAdressRegister.Add(IP, 1);
                }
                else
                {
                    ipAdressRegister[IP]++;
                }
            }

            return ipAdressRegister;
        }
    }
}