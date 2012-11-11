using System;

class FactorialsComplexExpression
{
    static void Main()
    {
        // Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

        // About
        Console.WriteLine("Print N!*K! / (K-N)! (1<N<K)");
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
        ulong nFactorial = Factorial(n);
        ulong kFactorialTopFactors = Factorial(k, k - n + 1);
        double product = nFactorial * kFactorialTopFactors;
        Console.WriteLine("{0}! * {1}! / ({1} - {0})! = {2} * {3} = {4:F8}",
            n, k, nFactorial, kFactorialTopFactors, product);
        // Test
        ulong kFactorial = Factorial(k);
        ulong differenceFactorial = Factorial(k - n);
        product = nFactorial * kFactorial / differenceFactorial;
        Console.WriteLine("{0}! * {1}! / ({1} - {0})! = {2} * {3} / {4} = {5:F8}",
            n, k, nFactorial, kFactorial, differenceFactorial, product);
    }

    static ulong Factorial(ulong maxFactor, ulong minFactor = 1)
    {
        ulong factorial = 1;
        for (ulong i = minFactor; i <= maxFactor; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}
