using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Grades
{
    class AverageGrades
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var students = new List<Student>();

            for (int i = 0; i < number; i++)
            {
                var data = Console.ReadLine().Split().ToList();
                var grades = data
                    .Skip(1)
                    .Take(data.Count - 1)
                    .Select(double.Parse)
                    .ToArray();

                var student = new Student()
                {
                    Name = data[0],
                    Grades = grades,
                };

                students.Add(student);
            }

            var filteredStudents = students
                .Where(x => x.average >= 5.0)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.average)
                .ToList();

            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{student.Name} -> {student.average:f2}");
            }
        }
    }
}
