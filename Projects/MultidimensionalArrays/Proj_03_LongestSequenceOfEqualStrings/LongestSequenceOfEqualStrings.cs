using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace MiltidimArrays
{
    public class StringSequences : StringArrays
    {
        // Test
        public static void Main()
        {
            // Get the original IO streams
            TextReader standardReader = Console.In;
            TextWriter standardWriter = Console.Out;
            // Redirect IO
            string input = "TestInput001.txt";
            string output = "TestOutput001.txt";
            StreamReader reader = new StreamReader(input);
            StreamWriter writer = new StreamWriter(output);
            Console.SetIn(reader);
            Console.SetOut(writer);
            //
            Run();
            // Close 
            reader.Close();
            writer.Close();
            // Set input and output to standard IO streams
            Console.SetIn(standardReader);
            Console.SetOut(standardWriter);
            //
            string ruler = new string('*', 50);
            Console.WriteLine(ruler);
            Console.WriteLine("Input was redirected from {0}", input);
            Console.WriteLine("Output was redirected to {0}", output);
            Console.WriteLine(ruler);
            Console.WriteLine("The Input\n" + ruler);
            DisplayFileContent(input);
            Console.WriteLine(ruler);
            Console.WriteLine("The Output\n" + ruler);
            DisplayFileContent(output);
        }
        public static void Run()
        {
            string[,] matrix;
            int rows = 0;
            do
            {
                matrix = ReadStringMatrix(new char[] { ' ' });
                rows = matrix.GetLength(0);
                if (rows > 0)
                {
                    PrintMatrix<string>(matrix);
                    Console.WriteLine();
                    Console.WriteLine("Longest = " + LongestSequence(matrix).ToString());
                    Console.WriteLine(new string('-', 40));
                }
            }
            while (rows > 0);
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
    public class StringArrays
    {
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
        public static string[] ReadStringVector()
        {
            List<string> input = new List<string>();
            string line = Console.ReadLine();
            // Input stops at the end of the file or an empty line
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
        public static void PrintMatrix<T>(T[,] matrix)
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
        public static void DisplayFileContent(string file)
        {
            StreamReader reader = new StreamReader(file); 
            string line = reader.ReadLine();
            // Input stops only at the end of the file
            while (line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
        }
    }
}