namespace GasStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int code = int.Parse(Console.ReadLine());
            
            int gasolina = 0;
            int alcool = 0;
            int diesel = 0;

            while (code != 4)
            {
                if (code == 1)
                    alcool += 1;
                else if (code == 2)
                    gasolina += 1;
                else if(code == 3)
                    diesel += 1;

                code = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Alcool: {0}", alcool);
            Console.WriteLine("Gasolina: {0}", gasolina);
            Console.WriteLine("Diesel: {0}", diesel);
        }
    }
}
