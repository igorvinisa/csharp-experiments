using EmployeeSalaryWithPolimorfism.Entities;
using System.Globalization;

namespace EmployeeSalaryWithPolimorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Employees: ");
            int number = int.Parse(Console.ReadLine());

            List<Employee> listEmployees= new List<Employee>();

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                
                Console.Write("Name: ");
                string name = Console.ReadLine();
                
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                
                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listEmployees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                    listEmployees.Add(new Employee(name, hours, valuePerHour));
            }

            Console.WriteLine("PAYMENTS:");

            foreach(var employee in listEmployees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
