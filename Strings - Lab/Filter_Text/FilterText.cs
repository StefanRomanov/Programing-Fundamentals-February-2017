using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_Text
{
    class FilterText
    {
        public static void Main()
        {
            var bannedWords = Console.ReadLine().Split(", ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).ToArray();

            var text = Console.ReadLine();
            
            foreach (var word in bannedWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}