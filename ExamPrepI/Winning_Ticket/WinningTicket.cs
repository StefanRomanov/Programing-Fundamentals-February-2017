using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Winning_Ticket
{
    class WinningTicket
    {
        public static void Main()
        {
            var tickets = Console.ReadLine()
                    .Split(new[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            var winning = new Regex("(\\${6,}|@{6,}|#{6,}|\\^{6,})");

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                else
                {
                    var leftHalf = ticket.Substring(0, 10);
                    var rightHalf = ticket.Substring(10, 10);

                    var leftMatch = winning.Match(leftHalf);
                    var rightMatch = winning.Match(rightHalf);

                    if ((leftMatch.Success && rightMatch.Success))
                    {
                        var leftSymbols = leftMatch.Value;
                        var rightSymbols = rightMatch.Value;
                        var min = Math.Min(rightSymbols.Length, leftSymbols.Length);

                        if (rightSymbols[0] == leftSymbols[0] && min < 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {min}{leftSymbols[0]}");
                        }
                        else if(rightSymbols[0] == leftSymbols[0] && min == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {min}{leftSymbols[0]} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - no match");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }
    }
}