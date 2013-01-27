using System;

class MaximalSumSubsequence
{
    /* Write a program that finds the sequence of maximal sum 
     * in given array. Can you do it with only one loop (with
     * single scan through the elements of the array)?
     */
    static void Main()
    {
        // Input data
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("a[{0}] = ", i);
            a[i] = int.Parse(Console.ReadLine());
        }
        // Calculate
        int max = int.MinValue;
        int start = 0;
        int end = 0;
        for (int i = 0; i < a.Length; i++)
        {
            int sum = 0;
            for (int j = i; j < a.Length; j++)
            {
                sum += a[j];
                if (sum > max)
                {
                    max = sum;
                    start = i;
                    end = j;
                }
            }
        }
        // Print on screen subsequence with maximal sum
        for (int i = start; i <= end; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}
