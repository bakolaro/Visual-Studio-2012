using System;

class PrintNaturalNumbers
{
    static void Main()
    {
        /* Write a program that reads an integer number n from the console and prints all 
         * the numbers in the interval [1..n], each on a single line.
         */

        // About
        Console.WriteLine("Print first natural numbers:");
        // Input data
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        // Output data
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}
