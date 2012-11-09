using System;
using System.Numerics;

class Fibonacci
{
    static void Main()
    {
        /* Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 
         * 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
         */

        // About
        Console.WriteLine("First 100 members of Fibonacci series:");
        // Calculate
        BigInteger[] fibonacci = new BigInteger[100];
        fibonacci[0] = 0;
        fibonacci[1] = 1;
        for (int i = 2; i < 100; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }
        // Output data
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("{0,4}. {1,35}", i + 1, fibonacci[i]);
        }
    }
}
