using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_Emails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            var emailRegister = new Dictionary<string, string>();

            while (name != "stop")
            {
                var email = Console.ReadLine()
                    .Trim();

                var domain = email
                    .Split('.')
                    .ToArray();

                if (domain[domain.Length - 1] != "us" && domain[domain.Length - 1] != "uk")
                {
                    emailRegister.Add(name, email);   
                }

                name = Console.ReadLine();
            }

            foreach (var record in emailRegister)
            {
                Console.WriteLine($"{record.Key} -> {record.Value}");
            }

        }
    }
}
