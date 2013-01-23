using System;

// Add reference to IOArrays (a class library in this solution)

public class BiggerThanNeighbors
{
    /* Write a method that checks if the element at given position 
     * in given array of integers is bigger than its two neighbors (when such exist).
     */
    public static void Main()
    {
        IOArrays.WriteInputFormatSpecification();
        string input = "BiggerThanNeighbors.in";
        Console.WriteLine(@"Input integer vectors from file (""bin/.../{0}"")", input);

        int[][] a = IOArrays.ReadIntVectorsFromFile(input);
        for (int i = 0; i < a.Length; i++)
        {
            IOArrays.WriteVector<int>(a[i]);
        }
        Console.Write("Choose a position, p = ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for (int i = 0; i < a.Length; i++)
        {
            IOArrays.WriteVector<int>(a[i]);
            if (IsBiggerThanNeighbors(a[i], p))
            {
                Console.WriteLine("Element at position {0} is bigger than its neighbors.", p);
            }
            else
            {
                Console.WriteLine("Element at position {0} is NOT bigger than its neighbors.", p);
            }
            Console.WriteLine();
        }
    }
    public static bool IsBiggerThanNeighbors(int[] a, int p)
    {
        int n = a.Length;
        return (p > 0) && (p < n - 1) && (a[p] > a[p - 1]) && (a[p] > a[p + 1]);
    }
}