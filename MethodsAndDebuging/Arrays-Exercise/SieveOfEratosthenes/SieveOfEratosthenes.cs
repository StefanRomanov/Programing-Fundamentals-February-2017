using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var primes = new bool[num + 1];

            for (int i = 0; i <= num; i++)
            {
                primes[i] = true;
            }

            primes[0] = false;
            primes[1] = false;

            for (int i = 0; i <= num; i++)
            {

                if (primes[i] == true)
                {
                    for (int j = 2; i * j <= num; j++)
                    {
                        primes[i * j] = false;
                    }
                }
            }

            for (int i = 0; i <= num; i++)
            {
                if (primes[i] == true)
                {
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine();
        }
    }
}
