using System;
using System.Numerics;

class FactorialsRatio
{
    static void Main()
    {
        /* Write a program that calculates N!/K! for given N and K (1<K<N). */

        // About
        Console.WriteLine("Print N! / K! (1<K<N)");
        // Input data
        Console.Write("n (n > 2) = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k (1 < k < {0}) = ", n);
        int k = int.Parse(Console.ReadLine());
        // Validate input
        if (n <= k || k <= 1)
        {
            Console.WriteLine("Invaid input!");
            return;
        }
        // Output data
        Console.WriteLine("{0}! / {1}! = {2}", n, k, Factorial(n, k + 1));
    }

    static BigInteger Factorial(int maxFactor, int minFactor = 1)
    {
        BigInteger factorial = 1;
        for (int i = minFactor; i <= maxFactor; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}

