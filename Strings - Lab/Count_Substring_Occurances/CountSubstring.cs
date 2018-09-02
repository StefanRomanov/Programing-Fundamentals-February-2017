using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Substring_Occurrances
{
    class CountSubstring
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var substring = Console.ReadLine().ToLower();

            var count = 0;
            var index = 0;

            while (true)
            {
                var found = text.IndexOf(substring, index);

                if (found >= 0)
                {
                    count++;
                    index = found + 1;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
