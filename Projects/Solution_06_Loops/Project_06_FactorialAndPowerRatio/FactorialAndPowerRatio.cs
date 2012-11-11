using System;

class FactorialAndPowerRatio
{
    static void Main()
    {
        /* Write a program that, for given two integer numbers N and X, 
         * calculates the sum S = 1 + 1!/X + 2!/X^2 + … + N!/X^N
         */

        // About
        Console.WriteLine("Calculate S = 1 + 1!/X + 2!/X^2 + … + N!/X^N");
        // Input data
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());
        // Validate input
        if (n < 0)
        {
            Console.WriteLine("Invalid input ({0} < 0)", n);
            return;
        }
        // Calculate
        double sum = 1.0;
        for (int i = 1; i <= n; i++)
        {
            sum += SameFactorialAndPowerRatio(n, x);
        }
        // Output data
        Console.WriteLine("S = {0:F6}", sum);
    }

    static double SameFactorialAndPowerRatio(int n, int x)
    {
        double ratio = 1.0;
        for (int i = 1; i <= n; i++)
        {
            ratio *= (double)i / x;
        }
        return ratio;
    }
}