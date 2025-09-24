using System.Globalization;

namespace WeightedAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int casesCount = int.Parse(Console.ReadLine());
            string[] vet;
            double[] weightedAverage = new double[casesCount];

            for (int i = 0; i < casesCount; i++)
            {
                vet = Console.ReadLine().Split(' ');
                double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

                weightedAverage[i] = (a * 2 + b * 3 + c * 5) / 10;

            }

            Console.WriteLine(weightedAverage[0].ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(weightedAverage[1].ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(weightedAverage[2].ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
