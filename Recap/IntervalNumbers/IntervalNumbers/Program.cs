namespace IntervalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int qtdOut = 0;
            int qtdIn = 0;
            int qtdValues = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtdValues; i++)
            {
                 number = int.Parse(Console.ReadLine());

                if(number < 10 || number > 20)
                {
                    qtdOut++;
                }
                else
                {
                    qtdIn++;
                }
            }
            
            Console.WriteLine($"{qtdIn} in");
            Console.WriteLine($"{qtdOut} out");
        }
    }
}
