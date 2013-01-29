using System;
using System.IO;

// Add reference to IOArrays

class MaxEqualNeighbors
{
    /* Write a program that finds the largest area of 
     * equal neighbor elements in a rectangular matrix
     * and prints its size.
     */
    static void Main()
    {
        string file = "Neighbors.txt";
        Console.WriteLine("Input test data from {0}:", file);
        int[][,] a = IOArrays.ReadIntMatricesFromFile(file);
        foreach (int[,] matrix in a)
        {
            IOArrays.WriteMatrix<int>(matrix);
            Console.WriteLine("Largest area = {0}", Max(matrix));
            Console.WriteLine();
        }
    }
    public static int Max(int[,] a)
    {
        bool[,] isVisited = new bool[a.GetLength(0), a.GetLength(1)];
        int max = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                int count = CountAccessibleNeighbors(a, isVisited, i, j, a[i, j]);
                if (count > max)
                {
                    max = count;
                }
            }
        }
        return max;
    }
    public static int CountAccessibleNeighbors(int[,] cells, bool[,] isVisited, int row, int column, int value)
    {
        if (row < 0 || row > cells.GetLength(0) - 1 ||
            column < 0 || column > cells.GetLength(1) - 1 ||
            isVisited[row, column] || cells[row, column] != value)
        {
            return 0;
        }
        else
        {
            isVisited[row, column] = true;
            return 1 + CountAccessibleNeighbors(cells, isVisited, row + 1, column, value) +
                CountAccessibleNeighbors(cells, isVisited, row - 1, column, value) +
                CountAccessibleNeighbors(cells, isVisited, row, column + 1, value) +
                CountAccessibleNeighbors(cells, isVisited, row, column - 1, value);
        }
    }
}