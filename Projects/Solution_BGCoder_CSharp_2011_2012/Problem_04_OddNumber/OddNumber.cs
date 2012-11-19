using System;
using System.Collections.Generic;

class OddNumber
{
    static void Main()
    {
        // -9,223,372,036,854,775,808 == long.MinValue
        //  9,223,372,036,854,775,807 == long.MaxValue
        // long.MinValue <= a[i] <= long.MaxValue
        // 1 <= i <= 99,999

        // Input data
        int n = int.Parse(Console.ReadLine());
        long[] a = new long[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = long.Parse(Console.ReadLine());
        }
        // Calculate
        HashSet<long> b = new HashSet<long>();
        for (int i = 0; i < n; i++)
        {
            
            if(b.Contains(a[i]))
            {
                b.Remove(a[i]);
            }
            else
            {
                b.Add(a[i]);
            }
        }
        HashSet<long>.Enumerator e = b.GetEnumerator();
        e.MoveNext();
        long oddOne = e.Current;
        // Output data
        Console.WriteLine(oddOne);
    }
}
