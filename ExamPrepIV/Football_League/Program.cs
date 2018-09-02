using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var standings = new Dictionary<string, int>();
            var goals = new Dictionary<string, long>();
            var key = Console.ReadLine();
            var teamDecrypt = new Regex(Regex.Escape(key) + "(.*?)" + Regex.Escape(key));
            var teams = new Regex(Regex.Escape(key) + "(.*?)" + Regex.Escape(key) + ".*?" + Regex.Escape(key) + "(.*?)" + Regex.Escape(key));
            var score = new Regex("(\\d+):(\\d+)");

            var game = Console.ReadLine();

            while (game != "final")
            {
                var matches = teamDecrypt.Matches(game);

                foreach (Match item in matches)
                {
                    var team = Reverse(item.Groups[1].ToString());

                    if (!standings.ContainsKey(team))
                    {
                        standings.Add(team, 0);
                    }
                    if (!goals.ContainsKey(team))
                    {
                        goals.Add(team, 0);
                    }
                }

                var firstTeam = Reverse(teams.Match(game).Groups[1].ToString());
                var secondTeam = Reverse(teams.Match(game).Groups[2].ToString());
                var firstScore = long.Parse(score.Match(game).Groups[1].ToString());
                var secondScore = long.Parse(score.Match(game).Groups[2].ToString());

                if (firstScore > secondScore)
                {
                    standings[firstTeam] += 3;
                }
                else if (firstScore < secondScore)
                {
                    standings[secondTeam] += 3;
                }
                else
                {
                    standings[firstTeam] += 1;
                    standings[secondTeam] += 1;
                }

                goals[firstTeam] += firstScore;
                goals[secondTeam] += secondScore;


                game = Console.ReadLine();
            }

            standings = standings.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            goals = goals.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("League standings:");
            var place = 1;

            foreach (var team in standings)
            {
                Console.WriteLine($"{place}. {team.Key} {team.Value}");
                place++;
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var team in goals)
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
            }
        }

        public static string Reverse(string Team)
        {
            var team = Team.ToCharArray();
            Array.Reverse(team);
            return new string(team).ToUpper();
        }
    }
}