using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class IOArrays
{
    public static int[][] ReadIntVectorsFromFile(string file)
    {
        int[][] x;

        TextReader generalReader = Console.In;
        StreamReader reader = new StreamReader(file);
        Console.SetIn(reader);

        List<int[]> input = new List<int[]>();
        int[] vector = ReadIntVector();
        while (vector.Length > 0)
        {
            input.Add(vector);
            vector = ReadIntVector();
        }
        int m = input.Count;
        x = new int[m][];
        for (int i = 0; i < m; i++)
        {
            x[i] = input[i];
        }

        reader.Close();
        Console.SetIn(generalReader);

        return x;
    }
    public static int[][,] ReadIntMatricesFromFile(string file, bool padRight = true)
    {
        int[][,] x;

        TextReader generalReader = Console.In;
        StreamReader reader = new StreamReader(file);
        Console.SetIn(reader);

        List<int[,]> input = new List<int[,]>();
        int[,] matrix = ReadIntMatrix(padRight);
        while (matrix.GetLength(0) > 0)
        {
            input.Add(matrix);
            matrix = ReadIntMatrix(padRight);
        }
        int m = input.Count;
        x = new int[m][,];
        for (int i = 0; i < m; i++)
        {
            x[i] = input[i];
        }

        reader.Close();
        Console.SetIn(generalReader);

        return x;
    }
    public static int[][][] ReadBigIntArraysFromFile(string file)
    {
        int[][][] x;

        TextReader generalReader = Console.In;
        StreamReader reader = new StreamReader(file);
        Console.SetIn(reader);

        List<int[][]> input = new List<int[][]>();
        int[][] matrix = ReadBigIntVectors();
        while (matrix.GetLength(0) > 0)
        {
            input.Add(matrix);
            matrix = ReadBigIntVectors();
        }
        int m = input.Count;
        x = new int[m][][];
        for (int i = 0; i < m; i++)
        {
            x[i] = input[i];
        }

        reader.Close();
        Console.SetIn(generalReader);

        return x;
    }
    private static int[] ReadIntVector()
    {
        List<string> input = new List<string>();
        string line = Console.ReadLine();
        while (line != null && line.Length > 0)
        {
            input.Add(line);
            line = Console.ReadLine();
        }
        int n = input.Count;
        int[] vector = new int[n];
        for (int i = 0; i < n; i++)
        {
            vector[i] = int.Parse(input[i]);
        }
        return vector;
    }
    private static int[,] ReadIntMatrix(bool padRight = true, params char[] delimiters)
    {
        List<string> input = new List<string>();
        string line = Console.ReadLine();
        while (line != null && line.Length > 0)
        {
            input.Add(line);
            line = Console.ReadLine();
        }
        int m = input.Count;
        string[][] split = new string[m][];
        for (int i = 0; i < m; i++)
        {
            split[i] = input[i].Split(delimiters);
        }
        int n = 0;
        for (int i = 0; i < m; i++)
        {
            if (split[i].Length > n)
            {
                n = split[i].Length;
            }
        }
        int[,] matrix = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            int k = split[i].Length;
            if (padRight)
            {
                for (int j = 0; j < k; j++)
                {
                    matrix[i, j] = int.Parse(split[i][j]);
                }
                for (int j = k; j < n; j++)
                {
                    matrix[i, j] = 0;
                }
            }
            else
            {
                for (int j = n - k; j < n; j++)
                {
                    matrix[i, j] = int.Parse(split[i][j - n + k]);
                }
                for (int j = 0; j < n - k; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }
        return matrix;
    }
    private static int[][] ReadBigIntVectors()
    {
        List<string> input = new List<string>();
        string line = Console.ReadLine();
        while (line != null && line.Length > 0)
        {
            input.Add(line);
            line = Console.ReadLine();
        }
        int m = input.Count;
        int[][] split = new int[m][];
        for (int i = 0; i < m; i++)
        {
            int n = input[i].Length;
            split[i] = new int[n];
            for (int j = 0; j < n; j++)
            {
                char digit = input[i][j];
                if (digit >= '0' && digit <= '9')
                {
                    split[i][j] = digit - 48;
                }
                else
                {
                    string err = string.Format("Invalid input! {0} is not a decimal digit!", digit);
                    throw new Exception(err);
                }
            }
        }
        return split;
    }
    public static void WriteMatrix<T>(T[,] matrix)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        int maxLength = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int length = matrix[i, j].ToString().Length;
                if (length > maxLength)
                {
                    maxLength = length;
                }
            }
        }
        maxLength++;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0," + maxLength + "}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
    public static void WriteVector<T>(T[] vector)
    {
        int m = vector.Length;
        for (int i = 0; i < m - 1; i++)
        {
            Console.Write("{0} ", vector[i]);
        }
        Console.WriteLine("{0}", vector[m - 1]);
    }
    public static void WriteBigIntArray(int[][] a, int columnWidth)
    {
        for (int i = 0; i < a.Length; i++)
        {
            StringBuilder str = new StringBuilder();
            for (int j = 0; j < a[i].Length; j++)
            {
                str.Append(a[i][j]);
            }
            string s = str.ToString().TrimStart('0');
            if (s.Length == 0)
            {
                s = "0";
            }
            Console.WriteLine("{0," + columnWidth + "}", s);
        }
    }
    public static void WriteBigIntArrayToFile(int[][] a, string file, int columnWidth)
    {
        TextWriter standardWriter = Console.Out;
        StreamWriter writer = new StreamWriter(file);
        Console.SetOut(writer);
        for (int i = 0; i < a.Length; i++)
        {
            StringBuilder str = new StringBuilder();
            for (int j = 0; j < a[i].Length; j++)
            {
                str.Append(a[i][j]);
            }
            string s = str.ToString().TrimStart('0');
            if (s.Length == 0)
            {
                s = "0";
            }
            Console.WriteLine("{0," + columnWidth + "}", s);
        }
        writer.Close();
        Console.SetOut(standardWriter);
    }
    public static void WriteBigInt(int[] a, int columnWidth)
    {
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < a.Length; i++)
        {
            str.Append(a[i]);
        }
        string s = str.ToString().TrimStart('0');
        if (s.Length == 0)
        {
            s = "0";
        }
        Console.WriteLine("{0," + columnWidth + "}", s);
    }
    public static void WriteInputFormatSpecification()
    {
        int width = 64;
        string hr = new string('*', width + 6);
        string format = "*  {0,-" + width + "}  *";
        Console.WriteLine(hr);
        Console.WriteLine(format, "Input format specification: IOArrays lets you easily parse");
        Console.WriteLine(format, "   a plain text file to an array of integer vectors, matrices");
        Console.WriteLine(format, "   or vectors of vectors (jagged two-dimensional arrays).");
        Console.WriteLine(format, "A vector input is a column of integer numbers ending");
        Console.WriteLine(format, "   with an empty line or at the end of the file.");
        Console.WriteLine(format, "A matrix input is a sequence of rows of integer numbers ending");
        Console.WriteLine(format, "   with an empty line or at the end of the file.");
        Console.WriteLine(format, "Row elements should be separated with single spaces and no");
        Console.WriteLine(format, "   row should end with space.");
        Console.WriteLine(format, "Incomplete rows in a matrix (with smaller number of elements)");
        Console.WriteLine(format, "   are left- or right-padded with zero elements.");
        Console.WriteLine(format, "A vector of vectors input is a sequence of undelimited lines of");
        Console.WriteLine(format, "   decimal digits ending with an empty line or at the end of");
        Console.WriteLine(format, "   the file.");
        Console.WriteLine(format, "Two empty lines act the same as end of file (all next");
        Console.WriteLine(format, "   input lines are ignored).");
        Console.WriteLine(hr);
        Console.WriteLine();
    }
}
