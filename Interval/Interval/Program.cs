using System.Globalization;

namespace Interval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float value = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(value < 0 || value > 100)
                Console.WriteLine("Fora do intervalo");
            else if (value <= 25)
                Console.WriteLine("(0,25]");
            else if (value <= 50)
                Console.WriteLine("(25,50]");
            else if (value <= 75)
                Console.WriteLine("(50,75]");
            else if (value <= 100)
                Console.WriteLine("(75,100]");
        }
    }
}
