using System;

// Add reference to IOArrays (a class library in this solution)

public class SelectionSortMax
{
    /* Write a method that return the maximal element in a portion of array of 
     * integers starting at given index. Using it write another method that 
     * sorts an array in ascending / descending order.
     */
    public static void Main()
    {
        IOArrays.WriteInputFormatSpecification();
        string input = "SelectionSortMax.in";
        Console.WriteLine(@"Input integer vectors from file (""bin/.../{0}"")", input);

        int[][] a = IOArrays.ReadIntVectorsFromFile(input);
        for (int i = 0; i < a.Length; i++)
        {
            IOArrays.WriteVector<int>(a[i]);
            Console.Write("Ascending: ");
            IOArrays.WriteVector<int>(Sort(a[i]));
            Console.Write("Descending: ");
            IOArrays.WriteVector<int>(Sort(a[i], false));
            Console.WriteLine();
        }
    }
    public static int GetIndex(int[] a, int startIndex = 0, bool ofMaximalElement = true)
    {
        int index = 0;
        int maxValue = int.MinValue;
        int minValue = int.MaxValue;
        for (int i = startIndex; i < a.Length; i++)
        {
            if (ofMaximalElement)
            {
                if (maxValue < a[i])
                {
                    maxValue = a[i];
                    index = i;
                }
            }
            else
            {
                if (minValue > a[i])
                {
                    minValue = a[i];
                    index = i;
                }
            }
        }
        return index;
    }
    public static int[] Sort(int[] a, bool inAscendingOrder = true)
    {
        int index = 0;
        for (int i = 0; i < a.Length - 1; i++)
        {
            index = GetIndex(a, i, !inAscendingOrder);
            int swap = a[i];
            a[i] = a[index];
            a[index] = swap;
        }
        return a;
    }
}