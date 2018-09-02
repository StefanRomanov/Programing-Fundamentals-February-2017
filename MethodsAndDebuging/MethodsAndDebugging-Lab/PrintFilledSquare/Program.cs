using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber = int.Parse(Console.ReadLine());
            HeaderFooter(userNumber);
            SquareMid(userNumber);
            HeaderFooter(userNumber);
        }
        static void HeaderFooter(int size)
        {
            Console.WriteLine(new string('-', size * 2));
        }
        static void SquareMid(int size)
        {
            for (int rows = 0; rows < size-2; rows++)
            {
                Console.Write('-');

                for (int col = 1; col < size; col++)
                {
                    Console.Write("\\/");
                }

                Console.WriteLine('-');
            }
        }
    }
}
