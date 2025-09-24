using System.Globalization;
namespace SellProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pecaUm = Console.ReadLine().Split(' ');
            string[] pecaDois = Console.ReadLine().Split(' ');

            double totalValue = int.Parse(pecaUm[1]) * double.Parse(pecaUm[2], CultureInfo.InvariantCulture) + int.Parse(pecaDois[1]) * double.Parse(pecaDois[2], CultureInfo.InvariantCulture);

            Console.WriteLine("VALOR A PAGAR: R$ " + totalValue.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}