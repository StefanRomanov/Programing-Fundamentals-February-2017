using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            var userString = Console.ReadLine().Trim();

            var alphabetArray = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'g', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < userString.Length; i++)
            {
                for (int j = 0; j < alphabetArray.Length; j++)
                {
                    if (alphabetArray[j] == userString[i] )
                    {
                        Console.WriteLine($"{alphabetArray[j]} -> {j}");
                    }
                }
            }
        }
    }
}
