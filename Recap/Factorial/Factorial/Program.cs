namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int valueFactorial = n;

            if (n == 0)
                Console.WriteLine(1);
            else
            {
                for (int i = 1; i < n; i++)
                {
                    valueFactorial *= n - i;
                }

                Console.WriteLine(valueFactorial);
            }
        }
    }
}
