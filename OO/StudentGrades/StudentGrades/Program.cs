using System.Globalization;

namespace StudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.Write("Nome do Aluno: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Digite as tres notas do aluno");
            student.FirstGrade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.SecondGrade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.ThirdGrade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.WriteLine(student);
        }
    }
}
