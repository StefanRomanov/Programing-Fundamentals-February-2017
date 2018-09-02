using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSeq
{
    class LastKNumbersSeq
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            var seq = new long[n];
            seq[0] = 1;

            for (int current = 1; current < n; current++)
            {
                var start = Math.Max(0, current - k);
                var end = current - 1;
                long sum = 0;
                 
                for (int i = start; i < n; i++)
                {
                    sum += seq[i];
                }

                seq[current] = sum;
            }
            Console.WriteLine(string.Join(" ", seq));
        }
    }
}
