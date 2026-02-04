namespace IncreaseSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered?");

            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i + 1}:");
                Console.Write("Id:");
                long id = long.Parse(Console.ReadLine());
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Salary:");
                decimal salary = decimal.Parse(Console.ReadLine());
                employees.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase :");
            long searchId = long.Parse(Console.ReadLine());
            Console.Write("Enter the percentage:");
            decimal percentage = decimal.Parse(Console.ReadLine());

            Employee emp = employees.Find(e => e.Id == searchId);
            if (emp != null)
            {
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            
            foreach (Employee e in employees)
            {
                Console.WriteLine($"{e.Id}, {e.Name}, {e.Salary:F2}");
            }
        }
    }
}
