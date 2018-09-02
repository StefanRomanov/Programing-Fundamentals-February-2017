using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < userNumber; i++)
            {
                PrintLine(1, i);
            }
            PrintLine(1, userNumber);
            for (int i = userNumber-1; i > 0; i--)
            {
                PrintLine(1, i);
            }
        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
