using System.Globalization;
namespace FeeRent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double feeRent = 0.0F;

            if (salary <= 2000.00)
            {
                Console.WriteLine("Isento");
                return;
            }
            else if (salary <= 3000.00)
                feeRent = (salary - 2000.00) * 0.08;
            else if (salary <= 4500.00)
                feeRent = (salary - 3000.00) * 0.18 + 1000 * 0.08;
            else
                feeRent = (salary - 4500.00) * 0.28 + 1500 * 0.18 + 1000 * 0.08;

            Console.WriteLine("R$ {0}", feeRent.ToString("F2", CultureInfo.InvariantCulture));
                
        }
    }
}
