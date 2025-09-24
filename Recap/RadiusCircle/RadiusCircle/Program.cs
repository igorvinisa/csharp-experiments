using System.Globalization;

namespace RadiusCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            Console.WriteLine("Entre com o raio do circulo: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * Math.Pow(radius, 2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));


        }
    }
}
