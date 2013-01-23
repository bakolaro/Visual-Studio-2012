using System;

// Add reference to IOArrays (a class library in this solution)

public class AddBigIntegers
{
    /* Write a method that adds two positive integer numbers represented as arrays
     * of digits (each array element arr[i] contains a digit; the last digit is 
     * kept in arr[0]). Each of the numbers that will be added could have up
     * to 10 000 digits.
     */
    public static void Main()
    {
        IOArrays.WriteInputFormatSpecification();
        string input = "AddBigIntegers.in";
        Console.WriteLine(@"Input integer vectors from file (""bin/.../{0}"")", input);

        int[][][] a = IOArrays.ReadBigIntArraysFromFile(input);
        for (int i = 0; i < a.Length; i++)
        {
            IOArrays.WriteBigIntArray(a[i], 60);
            Console.WriteLine("{0,60}", '=');
            IOArrays.WriteBigInt(AddIntegerVectors(a[i]), 60);
            Console.WriteLine();
        }
    }
    public static int[] AddIntegerVectors(int[][] a)
    {
        int m = a.Length;
        int n = CountColumns(a);
        int resultMaxNumberOfDigits = m.ToString().Length + n;
        int[] result = new int[resultMaxNumberOfDigits];
        
        int sum = 0;
        for (int j = 0; j < resultMaxNumberOfDigits; j++)
        {
            for (int i = 0; i < m; i++)
            {
                int length = a[i].Length;
                if (length > j)
                {
                    sum += a[i][length - 1 - j];
                }
            }
            result[resultMaxNumberOfDigits - 1 - j] = sum % 10;
            sum /= 10;
        }

        return result;
    }
    public static int CountColumns(int[][] a)
    {
        int n = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i].Length > n)
            {
                n = a[i].Length;
            }
        }
        return n;
    }
}
