using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var result = new List<string>();

            var arrayOfWords = input
                .Split(new char[] { ' ', ',', '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var word in arrayOfWords)
            {
                var temp = word.ToCharArray().Reverse().ToArray();
                var reversedWord = string.Join("", temp);

                if (reversedWord == word)
                {
                    result.Add(word);
                }
            }

            result = result.OrderBy(x => x).Distinct().ToList();
            var output = string.Join(", ", result);

            Console.WriteLine(output);
        }
    }
}
