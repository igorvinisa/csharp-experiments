using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class Employee
    {
        public string Name;

        public double GrossSalary;

        public double Tax;

        public double NetPay()
        {
            return GrossSalary - Tax;
        }

        public void IncreaseSalary(double percentage)
        {
            GrossSalary += GrossSalary * percentage / 100.0;
        }

        public override string ToString()
        {
            return Name
                + ", $ "
                + NetPay().ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
