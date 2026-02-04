namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("specify the order of a matrix N: ");
            int order = int.Parse(Console.ReadLine());

            int[,] matrix = new int[order, order];

            Console.WriteLine("Matrix Numbers: ");
            for (int i = 0; i < order; i++)
            {
                string[] elementsLine = Console.ReadLine().Split(' ');

                for (int j = 0; j < order; j++)
                {
                    matrix[i, j] = int.Parse(elementsLine[j]);
                }
            }

            int[] diagonalElements = MatrixOperations.GetDiagonalElements(matrix);

            Console.WriteLine("Diagonal Elements: ");
            for (int i = 0; i < diagonalElements.Length; i++)
            {
                Console.Write(diagonalElements[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Negative numbers count: " + MatrixOperations.GetNegativeElementsCount(matrix));

        }
    }
}
