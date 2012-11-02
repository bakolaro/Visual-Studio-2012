using System;

class CheckIfDigit3Is7
{
    static void Main()
    {
        // Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 ? true.
        Console.Write("Integer, n = ");
        int n = int.Parse(Console.ReadLine());
        bool is7The3rdDigit = ((n / 100) % 10 == 7);
        Console.WriteLine("The third digit (right-to-left) of {0} is 7. {1}.", n, is7The3rdDigit);
    }
}