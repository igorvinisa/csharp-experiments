namespace SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            int soma = numberOne + numberTwo;

            Console.WriteLine(soma);
        }
    }
}
