﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstOOP
{
    public class Student
    {
        public static int count = 0;

        public Student(string name)
        {
            this.Name = name;
            count++;
        }
        public string Name { get; set; }
    }
}
