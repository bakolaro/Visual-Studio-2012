using System;

class SwapTwoIntegers
{
    static void Main()
    {
        /* Write an if statement that examines two integer variables and exchanges their
         * values if the first one is greater than the second one.
         */

        // About
        Console.WriteLine("Exchange values of two variables if first is greater:");
        // Input data
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        // Calculate
        if (a > b)
        {
            int swap = a;
            a = b;
            b = swap;
        }
        // Output data
        Console.WriteLine("a = {0}; b = {1}", a, b);
    }
}
