using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Replace_Tag
{
    class ReplaceTag
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            var regex = new Regex(@"<a.*?href=(""|')(.*)\1>(.*?)<\/a>");

            while (command != "end")
            {
                var result = regex.Replace(command, @"[URL href=""$2""]$3[/URL]");

                Console.WriteLine(result);

                command = Console.ReadLine();
            }
        }
    }
}