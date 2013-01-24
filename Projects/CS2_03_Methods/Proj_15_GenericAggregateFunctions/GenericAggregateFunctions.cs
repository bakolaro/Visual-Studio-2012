using System;

public class GenericAggregateFunctions
{
    /* Modify your last program and try to make it work for any number 
     * type, not just Teger (e.g. decimal, float, byte, etc.). Use 
     * generic method (read in Ternet about generic methods in C#).
	 */
    public static void Main()
    {
        int[] a = {23, 45, 87, -45};
        WriteAggregates<int>(a);
        Console.WriteLine();
        byte[] b = { 3, 4, 15 };
        WriteAggregates<byte>(b);

        byte sum = 0;
        for (byte i = 0; i < 20; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum is int);
        Console.WriteLine();
    }
    public static void WriteAggregates<T>(params T[] numbers)
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
    public static T Min<T>(params T[] args)
    {
        dynamic min = args[0];
        for (int i = 1; i < args.Length; i++)
        {
            if (args[i] < min)
            {
                min = args[i];
            }
        }
        return min;
    }
    public static T Max<T>(params T[] args)
    {
        dynamic max = args[0];
        for (int i = 1; i < args.Length; i++)
        {
            if (args[i] > max)
            {
                max = args[i];
            }
        }
        return max;
    }
    public static double Average<T>(params T[] args)
    {
        dynamic d = Sum<T>(args);
        return d / (double) args.Length;
    }
    public static T Sum<T>(params T[] args)
    {
        dynamic sum = args[0];
        for (int i = 1; i < args.Length; i++)
        {
            Console.WriteLine(sum is byte);
            checked
            {
                sum = sum + args[i];
            }
        }
        return sum;
    }
    public static T Product<T>(params T[] args)
    {
        dynamic product = args[0];
        for (int i = 1; i < args.Length; i++)
        {
            checked
            {
                product *= args[i];
            }
        }
        return product;
    }
}