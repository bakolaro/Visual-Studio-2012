using System;

class MaximalSumSubset
{
    /* Write a program that reads two integer numbers N and K and
     * an array of N elements from the console. Find in the array
     * those K elements that have maximal sum.
     */
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("a[{0}] = ", i);
            a[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(a);
        for (int i = 0; i < k; i++)
        {
            Console.WriteLine(a[a.Length - 1 - i]);
        }
    }
}