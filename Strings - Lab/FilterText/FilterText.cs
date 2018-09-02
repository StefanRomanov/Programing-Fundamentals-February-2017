using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_Text
{
    class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var bannedWords = new[]
            {
                "Linux",
                "Windows",
            };

            foreach (var word in bannedWords)
            {
               text = text.Replace(word, new string('*', word.Length));
            }
        }

        Console.WriteLine(text);
    }
}
