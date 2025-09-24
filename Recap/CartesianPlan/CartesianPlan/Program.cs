namespace CartesianPlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            float x = float.Parse(vet[0]);
            float y = float.Parse(vet[1]);


            if (x == 0.0 && y == 0.0)
                Console.WriteLine("Origem");
            else if (x < 0.0 && y < 0.0)
                Console.WriteLine("Q3");
            else if (x < 0.0 && y > 0.0)
                Console.WriteLine("Q2");
            else if (x > 0.0 && y < 0.0)
                Console.WriteLine("Q4");
            else
                Console.WriteLine("Q1");
        }
    }
}
