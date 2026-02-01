using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRent
{
    public class Rent
    {
        public string Name { get; set; }

        public string Mail { get; set; }

        public Rent(string name, string mail)
        {
            Name = name;
            Mail = mail;
        }

    }
}
