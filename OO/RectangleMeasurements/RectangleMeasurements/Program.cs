using System.Globalization;

namespace RectangleMeasurements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            
            Console.WriteLine("Entre com a largura e altura do retangulo: ");

            rectangle.Base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rectangle.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(rectangle);
        }
    }
}
