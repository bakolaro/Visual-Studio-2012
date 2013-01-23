using System;

// Add reference to IOArrays (a class library in this solution)

public class IntegerAggregateFunctions
{
    /* Write methods to calculate minimum, maximum, average, sum and
	 * product of given set of integer numbers. Use variable number of arguments.
	 */
    public static void Main()
    {
        IOArrays.WriteInputFormatSpecification();
        string input = "IntegerAggregate.in";
        Console.WriteLine(@"Input integer vectors from file (""bin/.../{0}"")", input);

        int[][] a = IOArrays.ReadIntVectorsFromFile(input);
        for (int i = 0; i < a.Length; i++)
        {
            WriteIntegerAggregates(a[i]);
            Console.WriteLine();
        }
    }
    public static void WriteIntegerAggregates(params int[] numbers)
    {
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
    public static double Average(params int[] args)
    {
        return Sum(args) / (double) args.Length;
    }
    public static int Sum(params int[] args)
    {
        int sum = 0;
        for (int i = 0; i < args.Length; i++)
        {
            checked
            {
                sum += args[i];
            }
        }
        return sum;
    }
    public static int Product(params int[] args)
    {
        int product = 1;
        for (int i = 0; i < args.Length; i++)
        {
            checked
            {
                product *= args[i];
            }
        }
        return product;
    }
}