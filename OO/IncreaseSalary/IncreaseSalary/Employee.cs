using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreaseSalary
{
    public class Employee
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public decimal Salary { get; private set; }

        public Employee(long id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(decimal percentage)
        {
            Salary += Salary * (percentage / 100);
        }
    }
}
