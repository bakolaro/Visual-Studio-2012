using System;

class GreatestOfThreeIntegers
{
    static void Main()
    {
        /* Write a program that finds the biggest of three integers using nested if statements. */

        // About
        Console.WriteLine("The greatest of 3 integers:");
        // Input data
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        // Calulate
        int greatest;
        if (a < b)
        {
            if (b < c)
            {
                greatest = c;
            }
            else
            {
                greatest = b;
            }
        }
        else
        {
            if (a < c)
            {
                greatest = c;
            }
            else
            {
                greatest = a;
            }
        }
        // Output data
        Console.WriteLine("The greatest of {0}, {1} and {2} is {3}.", a, b, c, greatest);
    }
}
