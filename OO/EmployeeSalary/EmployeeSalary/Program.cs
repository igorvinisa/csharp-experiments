using System.Globalization;
namespace EmployeeSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.Write("Name: ");
            employee.Name = Console.ReadLine();
            Console.Write("Gross Salary: ");
            employee.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Tax: ");
            employee.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(employee);

            Console.WriteLine();
            Console.WriteLine("Which percentage to increase salary? ");

            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            employee.IncreaseSalary(percentage);

            Console.WriteLine();

            Console.WriteLine("Updated data: " + employee);
        }
    }
}
