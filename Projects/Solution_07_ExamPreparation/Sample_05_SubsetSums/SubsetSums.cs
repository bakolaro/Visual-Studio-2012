using System;

class SubsetSums
{
    static void Main()
    {
        // Input data
        long s = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        long[] a = new long[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = long.Parse(Console.ReadLine());
        }
        // Calculate
        int subsetsCounter = 0;
        int setMap = (1 << n) - 1;
        for (int subsetMap = 1; subsetMap <= setMap; subsetMap++)
        {
            long subsetSum = 0;
            for (int elementIndex = 0; elementIndex < n; elementIndex++)
            {
                // Element of this subset
                if (((subsetMap >> elementIndex) & 1) == 1)
                {
                    subsetSum += a[elementIndex];
                }
            }
            if (subsetSum == s)
            {
                subsetsCounter++;
            }
        }
        // Output data
        Console.WriteLine(subsetsCounter);
    }
}