namespace CartesianPlans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] coord = Console.ReadLine().Split(' ');

            int A = int.Parse(coord[0]);
            int B = int.Parse(coord[1]);

            while (A != 0 && B != 0)
            { 
                if (A > 0 && B > 0)
                {
                    Console.WriteLine("primeiro");
                } 
                else if (A < 0 && B > 0)
                {
                    Console.WriteLine("segundo");
                } 
                else if (A < 0 && B < 0)
                {
                    Console.WriteLine("terceiro");
                } 
                else
                {
                    Console.WriteLine("quarto");
                }
                
                coord = Console.ReadLine().Split(' ');
                A = int.Parse(coord[0]);
                B = int.Parse(coord[1]);
            }
        }
    }
}
