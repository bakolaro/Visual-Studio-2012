using System;

namespace MultidimensionalArrays
{
    public class ArrayMethods
    {
        public static string[,] ReadStringMatrix(int m, int n)
        {
            string[,] a = new string[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0}, {1}] = ", i, j);
                    a[i, j] = Console.ReadLine();
                }
            }
            return a;
        }
        public static void PrintMatrix(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void PrintMatrix(int[,] matrix, int row, int column, int rows, int columns)
        {
            for (int i = row; i < row + rows; i++)
            {
                for (int j = column; j < column + columns; j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static int SumMatrix(int[,] matrix)
        {
            int sum = 0;
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }
        public static int SumMatrix(int[,] matrix, int row, int column, int rows, int columns)
        {
            int sum = 0;
            for (int i = row; i < row + rows; i++)
            {
                for (int j = column; j < column + columns; j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }
        public static int[,] CopyMatrix(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            int[,] newMatrix = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    newMatrix[i, j] = matrix[i, j];
                }
            }
            return newMatrix;
        }
        public static int[,] CopyMatrix(int[,] matrix, int row, int column, int rows, int columns)
        {
            int[,] newMatrix = new int[rows, columns];
            for (int i = row; i < row + rows; i++)
            {
                for (int j = column; j < column + columns; j++)
                {
                    newMatrix[i - row, j - column] = matrix[i, j];
                }
            }
            return newMatrix;
        }
    }
}
