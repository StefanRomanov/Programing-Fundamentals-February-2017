using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Mentor_Group
{
    class MentorGroup
    {
        public static void Main()
        {
            var userAndDates = Console.ReadLine();
            var students = new List<Student>();

            while (userAndDates != "end of dates")
            {
                var data = userAndDates
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var name = data[0];
                var dates = new List<DateTime>();

                if (data.Count > 1)
                {
                    var dateArray = data
                        .Skip(1)
                        .Take(data.Count - 1)
                        .Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                        .ToArray();

                    dates.AddRange(dateArray);
                }

                if (!students.Exists(x => x.Name == name))
                {
                    var student = new Student()
                    {
                        Name = name,
                        Dates = dates,
                        Comments = new List<string>(),
                    };

                    students.Add(student);
                }
                else
                {
                    var currentStudent = students.First(x => x.Name == name);

                    currentStudent.Dates.AddRange(dates);
                }
                userAndDates = Console.ReadLine();
            }

            var comments = Console.ReadLine();
            var commentList = new List<string>();

            while (comments != "end of comments")
            {
                var data = comments.Split('-').ToList();

                var name = data[0];
                var comment = data[1];

                if (students.Exists(x => x.Name == name))
                {
                    var currentStudent = students.First(x => x.Name == name);

                    currentStudent.Comments.Add(comment);
                }

                comments = Console.ReadLine();
            }

            students = students.OrderBy(x => x.Name).ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}");
                Console.WriteLine("Comments:");

                foreach (var comment in student.Comments)
                {    
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");
                foreach (var date in student.Dates.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }
        }
    }
}
