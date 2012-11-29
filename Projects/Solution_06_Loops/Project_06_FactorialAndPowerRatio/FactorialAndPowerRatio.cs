using System;
using System.Globalization;
using System.Threading;

class FactorialAndPowerRatio
{
    static void Main()
    {
        /* Write a program that, for given two integer numbers N and X, 
         * calculates the sum S = 1 + 1!/X + 2!/X^2 + … + N!/X^N
         */

        // Set <decimal point> = <dot>
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        // About
        Console.WriteLine("                      1      2             N");
        Console.WriteLine("Calculate S = 1 + 1!/X + 2!/X  + ... + N!/X ");
        // Input data
        Console.Write("n (n >= 0) = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x (x > 0) = ");
        int x = int.Parse(Console.ReadLine());
        // Validate input
        if (n < 0 || x == 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        // Calculate
        double sum = 0.0;
        double[] addends = new double[n + 1];
        for (int i = 0; i <= n; i++)
        {
            addends[i] = FactorialToSamePowerRatio(i, x);
            sum += addends[i];
        }
        // Output data
        Console.Write("S = Sum (");
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}, ", addends[i]);
        }
        Console.WriteLine("{0}) = {1:F6}", addends[n], sum);
    }

    static double FactorialToSamePowerRatio(int n, int powerBase)
    {
        double ratio = 1.0;
        for (int i = 1; i <= n; i++)
        {
            ratio *= (double)i / powerBase;
        }
        return ratio;
    }
}