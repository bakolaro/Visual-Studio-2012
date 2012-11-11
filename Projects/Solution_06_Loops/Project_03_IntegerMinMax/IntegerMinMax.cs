using System;

class IntegerMinMax
{
    static void Main()
    {
        /* Write a program that reads from the console a sequence of N integer
         * numbers and returns the minimal and maximal of them.
         */

        // About
        Console.WriteLine("Print integers min and max:");
        // Input data
        Console.Write("Number of integers, n = ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("a[{0}] = ", i);
            a[i] = int.Parse(Console.ReadLine());
        }
        int min = int.MaxValue;
        int max = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            if (a[i] < min)
            {
                min = a[i];
            }
            if (a[i] > max)
            {
                max = a[i];
            }
        }
        // Output data
        Console.WriteLine("Max = {0}, Min = {1}", max, min);
    }
}
