using System.Globalization;

namespace CurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotacao do dolar? ");

            double rate = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares voce ira comprar? ");

            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = CurrencyConverter.ConvertToDollarWithIOF(rate, amount);

            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}