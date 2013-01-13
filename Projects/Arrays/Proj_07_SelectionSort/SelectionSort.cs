using System;

class SelectionSort
{
    /* Sorting an array means to arrange its elements in increasing
     * order. Write a program to sort an array. Use the "selection sort" 
     * algorithm: Find the smallest element, move it at the first 
     * position, find the smallest from the rest, move it at the
     * second position, etc.
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
        // Calculate
        for (int i = 0; i < n - 1; i++)
        {
            int smallest = a[i];
            int index = i;
            for (int j = i; j < n; j++)
            {
                if (a[j] < smallest)
                {
                    smallest = a[j];
                    index = j;
                }
            }
            int swap = a[index];
            a[index] = a[i];
            a[i] = swap;
        }
        // Print on screen sorted array
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}

