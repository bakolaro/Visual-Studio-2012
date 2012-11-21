using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        // Input data
        ulong[] a = new ulong[5];
        // (1 <= a[i] <= 100) V (i <> j <=> a[i] <> a[j])
        for (ulong i = 0; i < 5; i++)
        {
            a[i] = ulong.Parse(Console.ReadLine());
            
        }
        // Calculate
        ulong multiple = 1u;
        for (ulong i = 0; i < 5; i++)
        {
            multiple *= a[i];
        }
        // 1 * 2 * 3 * 4 * 5 <= multiple <= 100 * 99 * 98 * 97 * 96
        for (ulong i = 0; i < 3; i++)
        {
            for (ulong j = i + 1; j < 4; j++)
            {
                for (ulong k = j + 1; k < 5; k++)
                {
                    ulong m = LeastCommonMultiple(LeastCommonMultiple(a[i], a[j]), a[k]);
                    if (m < multiple)
                    {
                        multiple = m;
                    }
                }
            }
        }
        // Output data
        Console.WriteLine(multiple);
    }

    static ulong GreatestCommonDivisor(ulong a, ulong b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            return GreatestCommonDivisor(b, a % b);
        }
    }

    static ulong LeastCommonMultiple(ulong a, ulong b)
    {
        return (a * b) / GreatestCommonDivisor(a, b);
    }
}