using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork_Project
{
    class TeamworkProject
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            var teams = new List<Team>();

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine()
                    .Split('-')
                    .ToList();

                var creatorName = input[0];
                var teamName = input[1];

                if (teams.Exists(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Exists(x => x.Creator == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }
                else
                {
                    var team = new Team()
                    {
                        Name = teamName,
                        Creator = creatorName,
                        Members = new List<string>(),
                    };

                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                }
            }

            var command = Console.ReadLine();

            while (command != "end of assignment")
            {
                var data = command
                    .Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var memberName = data[0];
                var teamToJoin = data[1];


                if (!teams.Exists(x => x.Name == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else if (teams.Exists(x => x.Members.Contains(memberName)) || teams.Exists(x => x.Creator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamToJoin}!");
                }
                else
                {
                    var currentTeam = teams.First(x => x.Name == teamToJoin);
                    currentTeam.Members.Add(memberName);
                }

                command = Console.ReadLine();
            }

            var disbandTeams = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.Name)
                .ToList();

            var legitTeams = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.Name)
                .ToList();

            foreach (var team in legitTeams)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in disbandTeams)
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}