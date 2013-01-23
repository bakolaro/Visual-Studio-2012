using System;

// Add reference to IOArrays (a class library in this solution)
// Add reference to AddBigIntegers (a console application in this solution)

public class BigFactorial
{
    /* Write a program to calculate n! for each n in the range [1..100].
     * Hint: Implement first a method that multiplies a number represented
     * as array of digits by given integer number.
     */

    public static void Main()
    {
        int[][] a = new int[100][];
        a[0] = new int[1]{ 1 };
        for (int i = 1; i < 100; i++)
        {
            a[i] = IntegerVectorTimesConstant(a[i - 1], i + 1);
        }
        string output = "BigFactorial.out";
        Console.WriteLine(@"Factorials from 1! to 100! were exported to file (""bin/.../{0}"")", output);
        IOArrays.WriteBigIntArrayToFile(a, output, 1);
        IOArrays.WriteBigIntArray(a, 1);
    }
    public static int[] IntegerVectorTimesConstant(int[] a, int x)
    {
        int[][] vectors = new int[x][];
        for (int i = 0; i < x; i++)
        {
            vectors[i] = a;
        }
        return AddBigIntegers.AddIntegerVectors(vectors);
    }
}