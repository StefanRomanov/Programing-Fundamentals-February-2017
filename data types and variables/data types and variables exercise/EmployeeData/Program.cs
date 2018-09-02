using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();

            string lastName = Console.ReadLine();

            short age = short.Parse(Console.ReadLine());

            char gender = char.Parse(Console.ReadLine());

            long personalID = long.Parse(Console.ReadLine());

            int employeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}\n Last name: {lastName}\n Age: {age}\n Gender: {gender}\n Personal ID: {personalID}\n Unique Employee number: {employeeNumber}");
        }
    }
}
