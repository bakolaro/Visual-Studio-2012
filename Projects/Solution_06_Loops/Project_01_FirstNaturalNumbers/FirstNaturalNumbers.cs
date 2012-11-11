using System;

class FirstNaturalNumbers
{
    static void Main()
    {
        /* Write a program that prints all the numbers from 1 to N. */

        // About
        Console.WriteLine("Print numbers from 1 to N:");
        // Input data
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        // Output data
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(i + 1);
        }
    }
}
