namespace NegativeOrPositive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as horas: ");

            string[] vet = Console.ReadLine().Split(' ');

            int inicial = int.Parse(vet[0]);
            int final = int.Parse(vet[1]);

            int horaTotal = 0;

            if (final < 0 || inicial < 0 || final > 24 || inicial > 24)
                Console.WriteLine("Insira uma data valida");
            else if (inicial > final)
                horaTotal = inicial - final;
            else if (final > inicial)
                horaTotal = final - inicial;
            else
            {
                Console.WriteLine("O JOGO DUROU 24 HORAS");
                return;
            }

            Console.WriteLine("O JOGO DUROU {0} HORAS", horaTotal);



            //if( A >= B )
            //{
            //    if (A % B == 0)
            //        Console.WriteLine("Sao Multiplos");
            //    else
            //        Console.WriteLine("Nao sao Multiplos");
            //} else
            //{
            //    if (B % A == 0)
            //        Console.WriteLine("Sao Multiplos");
            //    else
            //        Console.WriteLine("Nao sao Multiplos");
            //}

            //if (number >= 0)
            //    Console.WriteLine("POSITIVO");
            //else
            //    Console.WriteLine("NEGATIVO");

            //if (number % 2 == 0)
            //    Console.WriteLine("Par");
            //else
            //    Console.WriteLine("Impar");

        }
    }
}
