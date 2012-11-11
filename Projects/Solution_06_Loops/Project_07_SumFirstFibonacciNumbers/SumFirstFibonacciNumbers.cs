using System;

class SumFirstFibonacciNumbers
{
    static void Main()
    {
        /* Write a program that reads a number N and calculates the sum of
         * the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3,
         * 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, … Each member of the 
         * Fibonacci sequence (except the first two) is a sum of the previous
         * two members.
         */

        // About
        Console.WriteLine("Sum first Fibonacci numbers:");
        // Input data
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        // Calculate
        ulong[] fibs = new ulong[n];
        fibs[0] = 0;
        fibs[1] = 1;
        ulong sum = 1;
        for (int i = 2; i < n; i++)
        {
            fibs[i] = fibs[i - 1] + fibs[i - 2];
            sum += fibs[i];
        }
        // Output data
        Console.Write("The sum of first {0} Fibonacci numbers is {1} (", n, sum);
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write("{0}, ", fibs[i]);
        }
        Console.WriteLine("{0})", fibs[n - 1]);
    }
}
