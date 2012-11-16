using System;

class PrintGreaterNumber
{
    static void Main()
    {
        /* Write a program that gets two numbers from the console and prints the greater
         * of them. Don’t use if statements.
         */

        // About
        Console.WriteLine("Prints the greater of two numbers:");
        // Input data
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        // Calculation
        int greater = (Math.Abs(a - b) + (a + b)) / 2;
        // Output data
        Console.WriteLine("Between {0} and {1}, {2} is greater.", a, b, greater);
    }
}
