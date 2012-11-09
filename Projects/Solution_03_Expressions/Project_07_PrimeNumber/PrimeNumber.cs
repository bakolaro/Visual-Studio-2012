using System;

class PrimeNumber
{
	static void Main()
    {
        // Write an expression that checks if given positive integer number n (n <= 100) is
        // prime. E.g. 37 is prime.

        // About
        Console.WriteLine("Is prime?");
        // Input data
        Console.Write("Integer, n (0 <= n <= 100) = ");
        int n = int.Parse(Console.ReadLine());
        // Calculate
        bool isPrime = ((n % 2 != 0) && (n % 3 != 0) && (n % 5 != 0) && (n % 7 != 0));
        // Output data
        Console.WriteLine("{0} is prime. {1}.", n, isPrime);
    }
}