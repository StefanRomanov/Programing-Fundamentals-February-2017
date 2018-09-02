using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {

            sbyte centuries = sbyte.Parse(Console.ReadLine());
            short years = (short)(100 * centuries);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            long seconds = Convert.ToInt64(minutes) * 60;
            long milliseconds = seconds * 1000;
            long microseconds = milliseconds * 1000;
            BigInteger nanoseconds = (BigInteger)microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
