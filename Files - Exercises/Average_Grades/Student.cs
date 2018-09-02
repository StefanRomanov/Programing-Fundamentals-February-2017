﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Grades
{
    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double Average => Grades.Average(x => x);
    }
}
