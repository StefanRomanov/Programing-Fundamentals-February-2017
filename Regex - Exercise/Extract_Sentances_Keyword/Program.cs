using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Extract_Sentances_Keyword
{
    class Program
    {
        public static void Main()
        {
            var keyword = Console.ReadLine();
            var text = Console.ReadLine();

            var regex = new Regex("\\b"+keyword+"\\b");

            var sentances = text.Split(new[] { '!', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var item in sentances)
            {
                if (regex.IsMatch(item))
                {
                    Console.WriteLine(string.Join(" ", item.Trim()));
                }
            }
        }
    }
}
