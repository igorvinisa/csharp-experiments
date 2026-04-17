using System.Data.Common;

namespace MatrixPositionOperations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write dimension of matrix MxN: ");
            string[] matrixOrder =  Console.ReadLine().Split(' ');

            int[,] matrix = new int[int.Parse(matrixOrder[0]), int.Parse(matrixOrder[1])];

            for (int line = 0; line < matrix.GetLength(0); line++)
            {
                string[] lines = Console.ReadLine().Split(' ');

                for(int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[line, column] = int.Parse(lines[column]);
                }
            }

            int numberForMatch = int.Parse(Console.ReadLine());

            for (int line = 0; line < matrix.GetLength(0); line++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (matrix[line, column].Equals(numberForMatch))
                    {
                        Console.WriteLine($"Position {line} , {column}");
                        if (column > 0)
                        {
                            Console.WriteLine("Left: " + matrix[line, column - 1]);
                        }
                        if (line > 0)
                        {
                            Console.WriteLine("Up: " + matrix[line - 1, column]);
                        }
                        if (column < line - 1)
                        {
                            Console.WriteLine("Right: " + matrix[line, column + 1]);
                        }
                        if (line < column - 1)
                        {
                            Console.WriteLine("Down: " + matrix[line + 1, column]);
                        }
                    }
                }
            }
        }
    }
}
