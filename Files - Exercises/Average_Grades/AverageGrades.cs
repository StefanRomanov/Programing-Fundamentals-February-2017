using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Average_Grades
{
    class AverageGrades
    {
        public static void Main()
        {
            var input = File.ReadAllLines("input.txt");

            var output = new List<string>();

            var numberStudents = int.Parse(input[0]);

            var result = new Dictionary<Student, double>();

            for (int i = 1; i <= numberStudents; i++)
            {
                var studentData = input[i].Split().ToArray();
                var studentName = studentData[0];
                var studentGrades = studentData.Skip(1).Take(studentData.Length - 1).Select(double.Parse).ToList();

                var student = new Student()
                {
                    Name = studentName,
                    Grades = studentGrades,
                };

                if (student.Average >= 5.00)
                {
                    result.Add(student, student.Average);
                }

            }

            result = result
                .OrderBy(x => x.Key.Name)
                .ThenByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var student in result)
            {
                output.Add($"{student.Key.Name} -> {student.Value:f2}");
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}
