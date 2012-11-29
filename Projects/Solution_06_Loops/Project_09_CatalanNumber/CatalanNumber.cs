using System;
using System.Numerics;

class CatalanNumber
{
    static void Main()
    {
        // Write a program to calculate the Nth Catalan number by given N.

        // About
        Console.WriteLine("Calculate the N-th Catalan number (counting from 0):");
        // Input data
        Console.Write("n (n >= 0) = ");
        int n = int.Parse(Console.ReadLine());
        // Validate input
        if (n < 0)
        {
            Console.WriteLine("Invalid input ({0} < 0)!", n);
            return;
        }
        // Calculate
        BigInteger catalan = Factorial(n + n, n + 2) / Factorial(n);
        // Output data
        Console.WriteLine("The {0}. Catalan number is {1}.", n, catalan);
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