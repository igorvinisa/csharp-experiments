namespace ValidatePassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int password = 0;

            while (password != 2002)
            {
                password = int.Parse(Console.ReadLine());

                if (password != 2002)
                    Console.WriteLine("Senha Invalida");
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}