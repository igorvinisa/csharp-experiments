using System.Globalization;

namespace TotalPay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int code = int.Parse(vet[0]);
            int qtd = int.Parse(vet[1]);
            double totalPay = 0;

            if (code == 1)
                totalPay = qtd * 4.00;
            else if (code == 2)
                totalPay = qtd * 4.50;
            else if (code == 3)
                totalPay = qtd * 5.00;
            else if (code == 4)
                totalPay = qtd * 2.00;
            else if (code == 5)
                totalPay = qtd * 1.50;

            Console.WriteLine("Total: R$ {0}", totalPay.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
