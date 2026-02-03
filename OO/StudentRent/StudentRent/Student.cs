using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRent
{
    public  class Student
    {
        public string Name { get; set; }

        public string Mail { get; set; }

        public Student(string name, string mail)
        {
            Name = name;
            Mail = mail;
        }

        public override string ToString()
        {
            return $"{Name}, {Mail}";
        }
    }
}
