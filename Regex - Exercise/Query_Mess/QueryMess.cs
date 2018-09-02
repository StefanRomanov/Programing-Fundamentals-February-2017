using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Query_Mess
{
    class QueryMess
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var spaces = new Regex("(%20|\\+|\\t|\\s)+");
            var pair = new Regex("([^&=?]*)=([^&=]*)");

            var queryData = new Dictionary<string, List<string>>();

            while (text != "END")
            {
                var pairs = pair.Matches(text);

                foreach (Match match in pairs)
                {
                    var key = match.Groups[1].Value;
                    key = spaces.Replace(key, " ").Trim();

                    var value = match.Groups[2].Value;
                    value = spaces.Replace(value, " ").Trim();

                    if (!queryData.ContainsKey(key))
                    {
                        queryData.Add(key, new List<string>());
                    }

                    queryData[key].Add(value);
                }

                foreach (var kvp in queryData)
                {
                    Console.Write($"{kvp.Key}=[{string.Join(", ", kvp.Value)}]");
                }

                Console.WriteLine();
                queryData.Clear();
                text = Console.ReadLine();
            }
        }
    }
}
