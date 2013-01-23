using System;
using System.IO;
using System.Collections.Generic;

public class IntegerAggregateFunctions
{
    /* Write methods to calculate minimum, maximum, average, sum and
	 * product of given set of integer numbers. Use variable number of arguments.
	 */
    public static void Main()
    {
        string input = "IntegerAggregate.in";
        Console.WriteLine("Read columns of integers from file (bin/.../{0})", input);
        Console.WriteLine("A column ends with an empty line or at the end of file.");
        int columns = IORedirect.RedirectInput<int, int>(input, LoopInput);
        Console.WriteLine("Aggregated columns count = {0}", columns);
    }
    public static int LoopInput(int[] x)
    {
        int count = 0;
        string[] args = IOArrays.ReadStringVector();
        while (args.Length > 0)
        {
            count++;
            int[] numbers = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                numbers[i] = int.Parse(args[i]);
            }
            WriteIntegerAggregates(numbers);
            args = IOArrays.ReadStringVector();
        }
        return count;
    }
    public static void WriteIntegerAggregates(params int[] numbers)
    {
        Console.WriteLine(new string('-', 30));
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        Console.WriteLine();
        Console.WriteLine("min = {0}", Min(numbers));
        Console.WriteLine("max = {0}", Max(numbers));
        Console.WriteLine("average = {0}", Average(numbers));
        Console.WriteLine("sum = {0}", Sum(numbers));
        Console.WriteLine("product = {0}", Product(numbers));
        Console.WriteLine(new string('-', 30));
    }
    public static int Min(params int[] args)
    {
        int min = int.MaxValue;
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] < min)
            {
                min = args[i];
            }
        }
        return min;
    }
    public static int Max(params int[] args)
    {
        int max = int.MinValue;
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] > max)
            {
                max = args[i];
            }
        }
        return max;
    }
    public static int Average(params int[] args)
    {
        return Sum(args) / args.Length;
    }
    public static int Sum(params int[] args)
    {
        int sum = 0;
        for (int i = 0; i < args.Length; i++)
        {
            sum += args[i];
        }
        return sum;
    }
    public static int Product(params int[] args)
    {
        int product = 1;
        for (int i = 0; i < args.Length; i++)
        {
            product *= args[i];
        }
        return product;
    }
}
public class IORedirect
{
    public delegate OutType Calc<InType, OutType>(InType[] args);
    public static OutType RedirectInput<InType, OutType>(string file, Calc<InType, OutType> c, params InType[] args)
    {
        TextReader standardReader = Console.In;
        StreamReader reader = new StreamReader(file);
        Console.SetIn(reader);
        OutType calc = c(args);
        reader.Close();
        Console.SetIn(standardReader);
        return calc;
    }
    public static OutType RedirectOutput<InType, OutType>(string file, Calc<InType, OutType> c, params InType[] args)
    {
        TextWriter standardWriter = Console.Out;
        StreamWriter writer = new StreamWriter(file);
        Console.SetOut(writer);
        OutType calc = c(args);
        writer.Close();
        Console.SetOut(standardWriter);
        return calc;
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
    public static void WriteMatrixColumns<T>(T[,] matrix)
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