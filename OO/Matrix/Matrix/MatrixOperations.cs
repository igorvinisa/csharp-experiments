using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public static class MatrixOperations
    {
        public static int[] GetDiagonalElements(int[,] matrix) {

            int[] diagonalElements = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        diagonalElements[i] = matrix[i, j];
                    }
                }
            }

            return diagonalElements;
        }

        public static int GetNegativeElementsCount(int[,] matrix) {
            
            int negativeCount = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        negativeCount++;
                    }
                }
            }
            return negativeCount;
        }
    }
}
