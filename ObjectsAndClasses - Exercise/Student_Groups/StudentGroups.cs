using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Student_Groups
{
    class StudentGroups
    {
        public static void Main()
        {
            var listOfTowns = ReadTownsAndStudents();
            var listOfGroups = DistributeGroups(listOfTowns);

            Console.WriteLine($"Created {listOfGroups.Count} groups in {listOfTowns.Count} towns:");

            foreach (var group in listOfGroups)
            {
                var emailArray = group.Students.Select(x => x.Email).ToArray();
                var emails = string.Join(", ", emailArray);
                Console.WriteLine($"{group.Town.Name} => {emails}");
            }
        }

        public static List<Town> ReadTownsAndStudents()
        {
            var inputLine = Console.ReadLine();
            var townList = new List<Town>();
            var lastTown = string.Empty;

            while (inputLine.ToLower() != "end")
            {
                
                if (inputLine.Contains("=>"))
                {
                    var data = inputLine.Split("=>".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
                    var seatsCount = data[1].Split().First();

                    var town = new Town()
                    {
                        Name = data[0],
                        SeatCount = int.Parse(seatsCount),
                        Students = new List<Student>(),
                    };

                    lastTown = town.Name;
                    townList.Add(town);
                }
                else
                {
                    var studentData = inputLine
                        .Split('|')
                        .Select(x => x.Trim())
                        .ToList();

                    var student = new Student()
                    {
                        Name = studentData[0],
                        Email = studentData[1],
                        RegistrationDate = DateTime.ParseExact(studentData[2],"d-MMM-yyyy",CultureInfo.InvariantCulture),
                    };

                    var currentTown = townList.First(x => x.Name == lastTown);
                    currentTown.Students.Add(student);
                }

                inputLine = Console.ReadLine();
            }

            return townList;
        }

        public static List<Group> DistributeGroups(List<Town> towns)
        {
            var groups = new List<Group>();

            foreach (var town in towns.OrderBy(x => x.Name))
            {
                var students = town
                    .Students.OrderBy(x => x.RegistrationDate)
                    .ThenBy(x => x.Name)
                    .ThenBy(x => x.Email)
                    .ToList();

                while (students.Any())
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = students.Take(town.SeatCount).ToList();
                    students = students.Skip(town.SeatCount).ToList();

                    groups.Add(group);
                }
            }

            return groups;
        }
    }
}