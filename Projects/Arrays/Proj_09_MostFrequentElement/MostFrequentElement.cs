﻿using System;

class MostFrequentElement
{
    /* Write a program that finds the most frequent number
     * in an array.
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
        int maxFreq = 0;
        int mode = 0;
        for (int i = 0; i < n; i++)
        {
            int counter = 1;
            for (int j = i + 1; j < n; j++)
            {
                if (a[j] == a[i])
                {
                    counter++;
                }
            }
            if (counter > maxFreq)
            {
                maxFreq = counter;
                mode = a[i];
            }
        }
        // Print on screen the most frequent value
        Console.WriteLine(mode);
    }
}