using System;

class OddOrEven
{
    static void Main()
    {
        // Write an expression that checks if given integer is odd or even.
        Console.Write("Integer, n = ");
        int n = int.Parse(Console.ReadLine());
        bool isEven = (n % 2 == 0);
        Console.WriteLine("{0} is even. {1}.", n, isEven);
    }
}