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
    public static int[][,] ReadIntMatricesFromFile(string file)
    {
        int[][,] x;

        TextReader generalReader = Console.In;
        StreamReader reader = new StreamReader(file);
        Console.SetIn(reader);

        List<int[,]> input = new List<int[,]>();
        int[,] matrix = ReadIntMatrix(' ');
        while (matrix.GetLength(0) > 0)
        {
            input.Add(matrix);
            matrix = ReadIntMatrix(' ');
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
    private static int[,] ReadIntMatrix(params char[] delimiters)
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
            for (int j = 0; j < k; j++)
            {
                matrix[i, j] = int.Parse(split[i][j]);
            }
            for (int j = k; j < n; j++)
            {
                matrix[i, j] = 0;
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
            Console.WriteLine("{0," + columnWidth + "}", str);
        }
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
        Console.WriteLine(format, "Input format specification: use IOArrays to");
        Console.WriteLine(format, "   get an array of integer vectors or matrices from file.");
        Console.WriteLine(format, "A vector is a column of integer numbers ending with");
        Console.WriteLine(format, "   an empty line or at the end of the file.");
        Console.WriteLine(format, "A matrix is a sequence of rows of integer numbers ending with");
        Console.WriteLine(format, "   an empty line or at the end of the file.");
        Console.WriteLine(format, "Row elements should be separated with single spaces.");
        Console.WriteLine(format, "An empty element (between two spaces) is considered");
        Console.WriteLine(format, "   to be equal to zero.");
        Console.WriteLine(format, "Two empty lines act the same as end of file (all next");
        Console.WriteLine(format, "   input lines are ignored).");
        Console.WriteLine(hr);
        Console.WriteLine();
    }
}
