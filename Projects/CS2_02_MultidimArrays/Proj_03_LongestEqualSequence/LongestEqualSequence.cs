using System;
using System.Text;

// Add reference to IOArrays

class LongestEqualSequence
{
    /* We are given a matrix of strings of size N x M. Sequences 
     * in the matrix we define as sets of several neighbor 
     * elements located on the same line, column or diagonal. 
     * Write a program that finds the longest sequence of equal 
     * strings in the matrix.
     */
    static void Main()
    {
        string file = "LinesOfEqualStrings.txt";
        Console.WriteLine("Input test data from {0}:", file);
        string[][,] a = IOArrays.ReadStringMatricesFromFile(file);
        foreach (string[,] matrix in a)
        {
            IOArrays.WriteMatrix<string>(matrix);
            Console.WriteLine("Largest area = {0}", LongestSequence(matrix));
            Console.WriteLine();
        }
    }
    public struct Sequence
    {
        public int Count;
        public string Value;
        override public string ToString()
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < Count - 1; i++)
            {
                s.Append(Value).Append(", ");
            }
            if (Count > 0)
            {
                s.Append(Value);
            }
            return s.ToString();
        }
    }
    public static Sequence LongestSequence(string[,] matrix)
    {
        Sequence[] s = new Sequence[4];
        s[0] = LongestSequenceByRows(matrix);
        s[1] = LongestSequenceByColumns(matrix);
        s[2] = LongestSequenceByMainDiagonal(matrix);
        s[3] = LongestSequenceBySecondDiagonal(matrix);
        Sequence max = new Sequence();
        foreach (Sequence x in s)
        {
            if (x.Count > max.Count)
            {
                max = x;
            }
        }
        return max;
    }
    public static Sequence LongestSequenceByRows(string[,] a)
    {
        int m = a.GetLength(0);
        int n = a.GetLength(1);
        Sequence max = new Sequence();
        for (int row = 0; row < m; row++)
        {
            Sequence s = new Sequence();
            for (int column = 0; column < n; column++)
            {
                if (column > 0 && a[row, column] == a[row, column - 1])
                {
                    s.Count++;
                }
                else
                {
                    s.Count = 1;
                    s.Value = a[row, column];
                }
                if (s.Count > max.Count)
                {
                    max = s;
                }
            }
        }
        return max;
    }
    public static Sequence LongestSequenceByColumns(string[,] a)
    {
        int m = a.GetLength(0);
        int n = a.GetLength(1);
        Sequence max = new Sequence();
        for (int column = 0; column < n; column++)
        {
            Sequence s = new Sequence();
            for (int row = 0; row < m; row++)
            {
                if (row > 0 && a[row, column] == a[row - 1, column])
                {
                    s.Count++;
                }
                else
                {
                    s.Count = 1;
                    s.Value = a[row, column];
                }
                if (s.Count > max.Count)
                {
                    max = s;
                }
            }
        }
        return max;
    }
    public static Sequence LongestSequenceByMainDiagonal(string[,] a)
    {
        int m = a.GetLength(0);
        int n = a.GetLength(1);
        Sequence max = new Sequence();
        for (int diagonal = 1 - m; diagonal <= n - 1; diagonal++)
        {
            int row, column;
            if (diagonal < 0)
            {
                row = -diagonal;
                column = 0;
            }
            else
            {
                row = 0;
                column = diagonal;
            }
            Sequence s = new Sequence();
            while (row < m && column < n)
            {
                if (row > 0 && column > 0 && a[row, column] == a[row - 1, column - 1])
                {
                    s.Count++;
                }
                else
                {
                    s.Count = 1;
                    s.Value = a[row, column];
                }
                if (s.Count > max.Count)
                {
                    max = s;
                }
                row++;
                column++;
            }
        }
        return max;
    }
    public static Sequence LongestSequenceBySecondDiagonal(string[,] a)
    {
        int m = a.GetLength(0);
        int n = a.GetLength(1);
        Sequence max = new Sequence();
        for (int diagonal = 1 - m; diagonal <= n - 1; diagonal++)
        {
            int row, column;
            if (diagonal < 0)
            {
                row = -diagonal;
                column = n - 1;
            }
            else
            {
                row = 0;
                column = diagonal;
            }
            Sequence s = new Sequence();
            while (row < m && column >= 0)
            {
                if (row > 0 && column < n - 1 && a[row, column] == a[row - 1, column + 1])
                {
                    s.Count++;
                }
                else
                {
                    s.Count = 1;
                    s.Value = a[row, column];
                }
                if (s.Count > max.Count)
                {
                    max = s;
                }
                row++;
                column--;
            }
        }
        return max;
    }
}