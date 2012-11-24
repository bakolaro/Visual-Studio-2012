using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        // Input data
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        // Calculate

        BigInteger[] x = new BigInteger[n];
        x[0] = a;
        x[1] = b;
        x[2] = c;
        for (int i = 3; i < n; i++)
        {
            x[i] = x[i - 3] + x[i - 2] + x[i - 1];
        }
        // Output data
        Console.WriteLine(x[n - 1]);
    }
}
