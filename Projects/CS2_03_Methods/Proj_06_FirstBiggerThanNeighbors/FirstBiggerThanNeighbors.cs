using System;

// Add reference to IOArrays (a class library in this solution)

public class FirstBiggerThanNeighbors
{
    /* Write a method that returns the index of the first element in array that 
     * is bigger than its neighbors, or -1, if there’s no such element. Use the
     * method from the previous exercise.
     */
    public static void Main()
    {
        IOArrays.WriteInputFormatSpecification();
        string input = "FirstBiggerThanNeighbors.in";
        Console.WriteLine(@"Input integer vectors from file (""bin/.../{0}"")", input);

        int[][] a = IOArrays.ReadIntVectorsFromFile(input);
        for (int i = 0; i < a.Length; i++)
        {
            IOArrays.WriteVector<int>(a[i]);
            int index = IndexOfFirstBiggerThanNeighbors(a[i]);
            if (index < 0)
            {
                Console.WriteLine("-1: There is no element bigger than its neighbors.", index);
            }
            else
            {
                Console.WriteLine("{0}: Element at position {0} is bigger than its neighbors.", index);
            }
            Console.WriteLine();
        }
    }
    public static int IndexOfFirstBiggerThanNeighbors(int[] a)
    {
        int n = a.Length;
        for (int i = 0; i < n; i++)
        {
            if (BiggerThanNeighbors.IsBiggerThanNeighbors(a, i))
            {
                return i;
            }
        }
        return -1;
    }
}
