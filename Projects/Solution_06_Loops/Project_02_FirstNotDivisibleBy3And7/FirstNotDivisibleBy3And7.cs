using System;

class FirstNotDivisibleBy3And7
{
    static void Main()
    {
        /* Write a program that prints all the numbers from 1 to N, that 
         * are not divisible by 3 and 7 at the same time.
         */

        // About
        Console.WriteLine("Print not divisible by 3 and 7 at the same time:");
        // Input data
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        // Output data
        for (int i = 1; i <= n; i++)
        {
            if(i % 3 > 0 || i % 7 > 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
