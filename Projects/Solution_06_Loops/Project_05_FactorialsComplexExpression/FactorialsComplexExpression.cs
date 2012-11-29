using System;
using System.Numerics;

class FactorialsComplexExpression
{
    static void Main()
    {
        // Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

        // About
        Console.WriteLine("Print N!*K! / (K-N)! (1<N<K)");
        // Input data
        Console.Write("n (n > 2) = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k (k > {0}) = ", n);
        int k = int.Parse(Console.ReadLine());
        // Validate input
        if (n <= 1 || k <= n)
        {
            Console.WriteLine("Invaid input!");
            return;
        }
        // Output data
        Console.WriteLine("{0}! * {1}! / {2}! = {3}", n, k, k - n,
            Factorial(n, 1) * Factorial(k, k - n + 1));
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
