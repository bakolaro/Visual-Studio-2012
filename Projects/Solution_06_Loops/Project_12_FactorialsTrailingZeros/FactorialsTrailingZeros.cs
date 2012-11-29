using System;
using System.Numerics;

class FactorialsTrailingZeros
{
    static void Main()
    {
        /* Write a program that calculates for given N how many trailing 
         * zeros present at the end of the number N!. Examples:
         * N = 10 -> N! = 3628800 -> 2
         * N = 20 -> N! = 2432902008176640000 -> 4
         * Does your program work for N = 50 000?
         * Hint: The trailing zeros in N! are equal to the number of its 
         * prime divisors of value 5. Think why!
         */

        // About
        Console.WriteLine("Count trailing zeros of a factorial:");
        // Input data
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        // Validate input
        if (n < 0)
        {
            Console.WriteLine("Invalid input ({0} < 0)!", n);
            return;
        }
        // Calculate
        int zeros = 0;
        for (int i = 1; i <= n; i++)
        {
            int remainder = i;
            while (remainder % 5 == 0)
            {
                zeros++;
                remainder /= 5;
            }
        }
        BigInteger factorial = Factorial(n);
        // Output data
        Console.WriteLine("N = {0} -> N! = {1:n0} -> {2} trailing zeros.", n, factorial, zeros);
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
