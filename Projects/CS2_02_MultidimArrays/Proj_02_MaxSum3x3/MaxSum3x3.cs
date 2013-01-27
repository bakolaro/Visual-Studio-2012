using System;

class MaxSum3x3
{
    /* Write a program that reads a rectangular matrix of 
     * size N x M and finds in it the square 3 x 3 that
     * has maximal sum of its elements.
     */
    static void Main()
    {
        IOArrays.WriteInputFormatSpecification();
        int[][,] a = IOArrays.ReadIntMatricesFromFile("Matrices.txt");
        for (int i = 0; i < a.Length; i++)
        {
            IOArrays.WriteMatrix<int>(a[i]);
            Console.WriteLine();
            IOArrays.WriteMatrix<int>(Max3x3(a[i]));
            Console.WriteLine();
        }
    }
    public static int[,] Max3x3(int[,] a)
    {
        int maxSum = int.MinValue;
        int indexRow = 0;
        int indexColumn = 0;
        for (int i = 0; i < a.GetLength(0) - 2; i++)
        {
            for (int j = 0; j < a.GetLength(1) - 2; j++)
            {
                int sum = 0;
                for (int ii = 0; ii < 3; ii++)
                {
                    for (int jj = 0; jj < 3; jj++)
                    {
                        sum += a[i + ii, j + jj];
                    }
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    indexRow = i;
                    indexColumn = j;
                }
            }
        }
        int[,] result = new int[3, 3];
        for (int ii = 0; ii < 3; ii++)
        {
            for (int jj = 0; jj < 3; jj++)
            {
                result[ii, jj] = a[indexRow + ii, indexColumn + jj];
            }
        }
        return result;
    }
}