using System.Globalization;

namespace AverageSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();

            Console.WriteLine("Enter name of employee 1:");
            Console.Write("Name: ");
            e1.Name = Console.ReadLine();
            Console.Write("Salary: ");
            e1.Salary = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  

            Console.WriteLine("Enter name of employee 2:"); 
            Console.Write("Name: ");
            e2.Name = Console.ReadLine();
            Console.Write("Salary: ");
            e2.Salary = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            decimal average = (e1.Salary + e2.Salary) / 2 ;

            Console.WriteLine($"Average salary: {average.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
