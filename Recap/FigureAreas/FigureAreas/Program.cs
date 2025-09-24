using System.Globalization;

namespace FigureAreas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vetData = Console.ReadLine().Split(' ');

            double A = double.Parse(vetData[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vetData[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vetData[2], CultureInfo.InvariantCulture);

            double areaTriangulo = (A * C) / 2;
            double areaCircle = Math.PI * Math.Pow(C, 2);
            double trapezio = (A + B) * C / 2;
            double quadrado = Math.Pow(B, 2);
            double rectangle = A * B;

            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCircle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + rectangle.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
