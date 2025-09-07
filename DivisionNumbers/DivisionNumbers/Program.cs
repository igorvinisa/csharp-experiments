using System.Globalization;

namespace DivisionNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int divisionsCount = int.Parse(Console.ReadLine());
            string[] numbers = null;
            for (int i = 0; i < divisionsCount; i++)
            {
                numbers = Console.ReadLine().Split(' ');

                int a = int.Parse(numbers[0]);
                int b = int.Parse(numbers[1]);

                if (b == 0)
                    Console.WriteLine("Divisao impossivel");
                else
                    Console.WriteLine(Convert.ToString((double) a/b, CultureInfo.InvariantCulture));
            }
        }
    }
}
