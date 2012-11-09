using System;

class OddOrEven
{
	static void Main()
    {
        // Write an expression that checks if a given integer is odd or even.

        // About
        Console.WriteLine("Odd or Even");
        // Input data
        Console.Write("Integer, n = ");
        int n = int.Parse(Console.ReadLine());
        // Calculate
        bool isEven = (n % 2 == 0);
        // Output data
        Console.WriteLine("{0} is even. {1}.", n, isEven);
    }
}