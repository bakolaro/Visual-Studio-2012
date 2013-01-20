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
        // Console.WriteLine(S(a, 0, k));
        int[] b = MaximalSubset(a, 0, k);
        for (int i = 0; i < b.Length; i++)
        {
            Console.WriteLine(b[i]);
        }
    }
    public static int[] MaximalSubset(int[] set, int index, int k)
    {
        int n = set.Length;
        if (n - index == k)
        {
            int[] subset = new int[k];
            for (int i = index; i < n; i++)
            {
                subset[i - index] = set[i];
            }
            return subset;
        }
        else if (k == 0)
        {
            return new int[0];
        }
        else
        {
            int[] x0 = MaximalSubset(set, index + 1, k);
            int[] x1 = new int[k];
            x1[0] = set[index];
            int sum1 = set[index];
            int[] t = MaximalSubset(set, index + 1, k - 1);
            for (int i = 0; i < t.Length; i++)
            {
                x1[i + 1] = t[i];
                sum1 += t[i];
            }
            int sum0 = 0;
            for (int i = 0; i < x0.Length; i++)
            {
                sum0 += x0[i];
            }
            if (sum0 > sum1)
            {
                return x0;
            }
            return x1;
        }
    }
    /*
    public static int S(int[] vector, int index, int k)
    {
        int n = vector.Length;
        if (n - index == k)
        {
            int sum = 0;
            for (int i = index; i < n; i++)
            {
                sum += vector[i];
            }
            return sum;
        }
        else if (k == 0)
        {
            return 0;
        }
        else
        {
            int x0 = S(vector, index + 1, k);
            int x1 = S(vector, index + 1, k - 1) + vector[index];
            if (x0 > x1)
            {
                return x0;
            }
            return x1;
        }
    }
    */
}