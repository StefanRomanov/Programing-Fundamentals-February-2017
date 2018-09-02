using System;
using System.Linq;

namespace Average_Grades
{
    public class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }

        public double average => Grades.Average();
    }
}
