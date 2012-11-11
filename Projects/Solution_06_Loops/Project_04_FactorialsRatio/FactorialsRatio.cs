using System;

class FactorialsRatio
{
    static void Main()
    {
        /* Write a program that calculates N!/K! for given N and K (1<N<K). */

        // About
        Console.WriteLine("Print N! / K! (1<N<K)");
        // Input data
        Console.Write("n = ");
        ulong n = ulong.Parse(Console.ReadLine());
        Console.Write("k = ");
        ulong k = ulong.Parse(Console.ReadLine());
        // Validate input
        if (n > k)
        {
            Console.WriteLine("Invaid input ({0} > {1})", n, k);
            return;
        }
        // Calculate
        ulong nFact = Factorial(n);
        ulong kFact = Factorial(k);
        double nkFactRatio = (double)nFact / kFact;
        // Output data
        Console.WriteLine("{0}! / {1}! = {2} / {3} = {4:F8}", n, k, nFact, kFact, nkFactRatio);
        // Test
        double nkFactorialsRatio = FactorialsRatio(n, k);
        Console.WriteLine("{0}! / {1}! = {2:F8}", n, k, nkFactorialsRatio);
    }

    static ulong Factorial(ulong n)
    {
        ulong factorial = 1;
        for (ulong i = 1u; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    static double FactorialsRatio(ulong n, ulong k)
    {
        ulong denominator = 1;
        for (ulong i = n + 1u; i <= k; i++)
        {
            denominator *= i;
        }
        return 1.0 / denominator;
    }
}

