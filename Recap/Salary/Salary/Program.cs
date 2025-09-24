using System.Globalization;

namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = (double)horas * valorHora;

            Console.WriteLine("Number = " + number);
            Console.WriteLine("Value = U$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
