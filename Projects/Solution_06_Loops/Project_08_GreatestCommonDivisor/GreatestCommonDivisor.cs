using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        /* Write a program that calculates the greatest common divisor (GCD)
         * of given two numbers. Use the Euclidean algorithm (find it in 
         * Internet).
         */

        // About
        Console.WriteLine("Euclidean algorithm for GCD of two natural numbers:");
        // Input data
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        // Validate input
        if (a < 1 || b < 1)
        {
            Console.WriteLine("Invalid input (a or b is not a natural number)!");
            return;
        }
        // Calculate
        int x = a;
        int y = b;
        // Let x <= y
        do
        {
            if (x > y)
            {
                int swap = x;
                x = y;
                y = swap;
            }
            y = y - x;
        }
        while (y > 0);
        int gcd = x;
        // Output data
        Console.WriteLine("The greatest common divisor of {0} and {1} is {2}.", a, b, gcd);
    }
}
