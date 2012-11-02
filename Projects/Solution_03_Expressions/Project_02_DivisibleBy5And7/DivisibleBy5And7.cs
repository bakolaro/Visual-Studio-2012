using System;

class DivisibleBy5And7
{
    static void Main()
    {
        // Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
        Console.Write("Integer, n = ");
        int n = int.Parse(Console.ReadLine());
        bool isDivisibleBy5And7 = (n % 7 == 0 && n % 5 == 0);
        Console.WriteLine("{0} can be divided by 7 and 5. {1}.", n, isDivisibleBy5And7);
    }
}