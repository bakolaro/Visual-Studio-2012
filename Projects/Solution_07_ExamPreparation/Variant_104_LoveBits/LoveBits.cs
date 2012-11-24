using System;

class LoveBits
{
    static void Main()
    {
        // Input data
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        // Calculate
        int[] b = new int[n];
        for (int i = 0; i < n; i++)
        {
            b[i] = ((a[i] ^ Inverted(a[i])) & Reversed(a[i]));
            Console.WriteLine("{3}: {0}: {1}: {2}", 
                Convert.ToString(a[i], 2), Convert.ToString(Inverted(a[i]), 2),
                Convert.ToString(Reversed(a[i]), 2), a[i]);
        }
        // Output data
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(b[i]);
        }
    }

    static int Inverted(int x)
    {
        int k = 0, inverted = 0;
        while (x > 0)
        {
            inverted |= (((~x) & 1) << k);
            k++;
            x >>= 1;
        }
        return inverted;
    }

    static int Reversed(int x)
    {
        uint reversed = 0u;
        uint upper = (uint)x;
        while (upper > 0u)
        {
            reversed = ((reversed << 1) | (upper & 1));
            upper >>= 1;
        }
        return (int)reversed;
    }
}

