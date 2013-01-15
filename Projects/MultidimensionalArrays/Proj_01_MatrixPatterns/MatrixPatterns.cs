using System;

namespace MultidimensionalArrays
{
    public class MatrixPatterns
    {
        public static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int[,] a = new int[n, n];
            GoDownByColumns(a);
            ArrayMethods.PrintMatrix(a);

            int[,] b = new int[n, n];
            GoDownAndUpByColumns(b);
            ArrayMethods.PrintMatrix(b);

            int[,] c = new int[n, n];
            GoSouthEast(c);
            ArrayMethods.PrintMatrix(c);

            int[,] d = new int[n, n];
            GoCounterClockwise(d);
            ArrayMethods.PrintMatrix(d);
        }
        public static void GoDownByColumns(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            int number = 1;
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    matrix[i, j] = number++;
                }
            }
        }
        public static void GoDownAndUpByColumns(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            int number = 1;
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    if (j % 2 == 0)
                    {
                        matrix[i, j] = number++;
                    }
                    else
                    {
                        matrix[n - 1 - i, j] = number++;
                    }
                }
            }
        }
        public static void GoSouthEast(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            int i = n - 1;
            int j = 0;
            for (int number = 1; number <= m * n; number++)
            {
                matrix[i, j] = number;
                i++;
                j++;
                if (i > m - 1 || j > n - 1)
                {
                    j++;
                    i -= j;
                    j = 0;
                    if (i < 0)
                    {
                        j -= i;
                        i = 0;
                    }
                }
            }
        }
        public static void GoCounterClockwise(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            int i = 0;
            int j = 0;
            int iDir = 1;
            int jDir = 0;
            for (int number = 1; number <= m * n; number++)
            {
                matrix[i, j] = number;
                i += iDir;
                j += jDir;
                if (i > m - 1 || j > n - 1 || i < 0 || j < 0 || matrix[i, j] > 0)
                {
                    i -= iDir;
                    j -= jDir;
                    if (iDir == 0)
                    {
                        iDir = -jDir;
                        jDir = 0;
                    }
                    else
                    {
                        jDir = iDir;
                        iDir = 0;
                    }
                    i += iDir;
                    j += jDir;
                }
            }
        }
    }
}