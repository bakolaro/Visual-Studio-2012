using System;

class MergeSort
{
    /* Write a program that sorts an array of integers
     * using the merge sort algorithm (find it in Wikipedia).
     */
    static void Main()
    {
        // Input data
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("a[{0}] = ", i);
            a[i] = int.Parse(Console.ReadLine());
        }
        Sort(a);
        foreach (var item in a)
        {
            Console.Write("{0,5}", item);
        }
        Console.WriteLine();
    }

    public static void Sort(int[] a)
    {
        int n = a.Length;
        // Split array
        int[] b = new int[n / 2];
        int[] c = new int[n - n / 2];
        for (int i = 0; i < n / 2; i++)
        {
            b[i] = a[i];
        }
        for (int i = 0; i < n - n / 2; i++)
        {
            c[i] = a[i + n / 2];
        }
        // Sort arrays
        if (n > 2)
        {
            Sort(b);
            Sort(c);
        }
        // Merge arrays
        int indexA = 0;
        int indexB = 0;
        int indexC = 0;
        while (indexB < n / 2 && indexC < n - n / 2)
        {
            if (b[indexB] < c[indexC])
            {
                a[indexA++] = b[indexB++];
            }
            else
            {
                a[indexA++] = c[indexC++];
            }
        }
        while (indexB < n / 2)
        {
            a[indexA++] = b[indexB++];
        }
        while (indexC < n - n / 2)
        {
            a[indexA++] = c[indexC++];
        }
    }
}
