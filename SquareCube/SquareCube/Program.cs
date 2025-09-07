namespace SquareCube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lineCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lineCount; i++)
            {
                long square = (long)Math.Pow(i, 2);
                long cube = (long)Math.Pow(i, 3);
                
                Console.WriteLine($"Number: {i}, Square: {square}, Cube: {cube}");
            }
        }
    }
}
