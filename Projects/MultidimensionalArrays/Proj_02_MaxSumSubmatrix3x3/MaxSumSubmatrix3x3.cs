using System;

namespace MultidimensionalArrays
{
    public class MaxSumSubmatrix3x3
    {
        public static void Main()
        {
            Console.Write("m (rows) = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("n (columns) = ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0}, {1}] = ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix:");
            ArrayMethods.PrintMatrix(matrix);
            int maxSum = int.MinValue;
            int maxTop = 0;
            int maxLeft = 0;
            for (int i = 0; i < m - 2; i++)
            {
                for (int j = 0; j < n - 2; j++)
                {
                    int sum = ArrayMethods.SumMatrix(matrix, i, j, 3, 3);
                    Console.WriteLine(sum);
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxTop = i;
                        maxLeft = j;
                    }
                }
            }
            Console.WriteLine("Sum of submatrix = {0}", maxSum);
            Console.WriteLine("Submatrix:");
            ArrayMethods.PrintMatrix(matrix, maxTop, maxLeft, 3, 3);
        }
    }
}