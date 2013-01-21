using System;
using System.IO;
using System.Collections.Generic;
using MultidimensionalArrays;

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
    public delegate int Calc(int[] args);
    public static int RedirectInput(string file, Calc c, params int[] args)
    {
        TextReader standardReader = Console.In;
        StreamReader reader = new StreamReader(file);
        Console.SetIn(reader);
        int inputLines = c(args);
        reader.Close();
        Console.SetIn(standardReader);
        return inputLines;
    }
    public static int RedirectOutput(string file, Calc c, params int[] args)
    {
        TextWriter standardWriter = Console.Out;
        StreamWriter writer = new StreamWriter(file);
        Console.SetOut(writer);
        int outputLines = c(args);
        writer.Close();
        Console.SetOut(standardWriter);
        return outputLines;
    }
}
public class IOArrays
{
    public static string[] ReadStringVector()
    {
        List<string> input = new List<string>();
        string line = Console.ReadLine();
        while (line != null && line.Length > 0)
        {
            input.Add(line);
            line = Console.ReadLine();
        }
        int n = input.Count;
        string[] vector = new string[n];
        for (int i = 0; i < n; i++)
        {
            vector[i] = input[i];
        }
        return vector;
    }
    public static string[][] ReadStringArray(char[] delimiters)
    {
        string[] vector = ReadStringVector();
        int m = vector.Length;
        string[][] arr = new string[m][];
        for (int i = 0; i < m; i++)
        {
            arr[i] = vector[i].Split(delimiters);
        }
        return arr;
    }
    public static string[,] ReadStringMatrix(char[] delimiters)
    {
        string[][] arr = ReadStringArray(delimiters);
        int m = arr.GetLength(0);
        int n = 0;
        for (int i = 0; i < m; i++)
        {
            int d = arr[i].Length;
            if (d > n)
            {
                n = d;
            }
        }
        string[,] matrix = new string[m, n];
        for (int i = 0; i < m; i++)
        {
            int d = arr[i].Length;
            for (int j = 0; j < d; j++)
            {
                matrix[i, j] = arr[i][j];
            }
            for (int j = d; j < n; j++)
            {
                matrix[i, j] = "";
            }
        }
        return matrix;
    }
    public static void WriteMatrixToColumns<T>(T[,] matrix)
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
}