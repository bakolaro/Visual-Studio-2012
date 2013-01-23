using System;

// Add reference to IOArrays (a class library in this solution)

public class CountSameValue
{
    /* Write a method that counts how many times given number appears in given
     * array. Write a test program to check if the method is working correctly.
     */
    public static void Main()
    {
        IOArrays.WriteInputFormatSpecification();
        string input = "CountSameIntegerValue.in";
        Console.WriteLine(@"Input integer vectors from file (""bin/.../{0}"")", input);

        int[][] a = IOArrays.ReadIntVectorsFromFile(input);
        for (int i = 0; i < a.Length; i++)
        {
            IOArrays.WriteVector<int>(a[i]);
        }
        Console.Write("Count same value, x = ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for (int i = 0; i < a.Length; i++)
        {
            IOArrays.WriteVector<int>(a[i]);
            Console.WriteLine("   {0} is repeated {1} times", x, Count(a[i], x));
            Console.WriteLine();
        }
    }
    public static int Count(int[] a, int x)
    {
        int count = 0;
        int n = a.Length;
        for (int i = 0; i < n; i++)
        {
            if (a[i] == x)
            {
                count++;
            }
        }
        return count;
    }
}
