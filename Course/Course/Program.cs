using System.Globalization;
using System.Text;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tipos de dados
            //    bool completo = false;
            //    char genero = 'F';
            //    char generounicode = '\u0041';
            //    sbyte x = 127;
            //    byte n1 = 126;
            //    int n2 = 1000;
            //    int n3 = 2147483647;
            //    long n4 = 2147483648L;
            //    float n5 = 4.5f;
            //    double n6 = 4.5;
            //    string nome = "Maria Green";
            //    object obj1 = "Alex Brown";
            //    object obj2 = 4.5f;

            //    Console.WriteLine(completo);
            //    Console.WriteLine(genero);
            //    Console.WriteLine(generounicode);
            //    Console.WriteLine(n1);
            //    Console.WriteLine(n2);
            //    Console.WriteLine(n3);
            //    Console.WriteLine(n4);
            //    Console.WriteLine(n5);
            //    Console.WriteLine(n6);
            //    Console.WriteLine(nome);

            //saidas de dados

            //char genero = 'F';
            //int idade = 32;
            //double saldo = 10.35784;
            //string nome = "Maria";
            //Console.WriteLine("Bom dia!");
            //Console.WriteLine("Boa tarde!");
            //Console.WriteLine("Boa noite!");
            //Console.WriteLine("---------------------");
            //Console.WriteLine(genero);
            //Console.WriteLine(idade);
            //Console.WriteLine(saldo);
            //Console.WriteLine(saldo.ToString("F2"));
            //Console.WriteLine(saldo.ToString("F4"));
            //Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            //Console.WriteLine(nome);

            ////placeholder
            //Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            ////interpolacao
            //Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo} reais");

            ////concatenacao
            //Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais");

            //atividade pratica de impressao de dados
            
            //string produto1 = "Computador";
            //string produto2 = "Mesa de escritorio";

            //byte idade = 30;
            //int codigo = 5290;
            //char genero = 'M';

            //double preco1 = 2100.0;
            //double preco2 = 650.50;
            //double medida = 53.234567;

            //Console.WriteLine("Produtos:");
            //Console.WriteLine($"{produto1}, cujo preco e $ {preco1:F2}");
            //Console.WriteLine("{0}, cujo o preco e $ {1:F2}", produto2, preco2);
            //Console.WriteLine("");
            //Console.WriteLine("Registro: " + idade + " anos de idade, codigo " + codigo + " e genero: " + genero);
            //Console.WriteLine("");
            //Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
            //Console.WriteLine($"Arredondado (tres casas decimais): {medida:F3}");
            //Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
