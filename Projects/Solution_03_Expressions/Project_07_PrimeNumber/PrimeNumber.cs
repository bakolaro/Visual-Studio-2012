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
        Console.Write("Integer, n (1 <= n <= 100) = ");
        int n = int.Parse(Console.ReadLine());
        // Validate input
        if (n < 1 || 100 < n)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        // Calculate
        bool is2357 = ((n == 2) || (n == 3) || (n == 5) || (n == 7));
        bool isCoPrimeTo2357 = ((n % 2 > 0) && (n % 3 > 0) && (n % 5 > 0) && (n % 7 > 0));
        bool isPrime = (is2357 || isCoPrimeTo2357 && (n > 1));
        // Output data
        Console.WriteLine("{0} is prime? {1}.", n, isPrime);
    }
}