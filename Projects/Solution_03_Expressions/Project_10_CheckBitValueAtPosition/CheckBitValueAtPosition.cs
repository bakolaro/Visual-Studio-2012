using System;

class CheckBitValueAtPosition
{
	static void Main()
    {
        // Write a boolean expression that returns if the bit at position p (counting from 0) in
        // a given integer number v has value of 1. Example: v=5; p=1 -> false.

        // About
        Console.WriteLine("Bit p in v is 1");
        // Input data
        Console.Write("Integer, v = ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Bit position, p (0 <= p <= 31) = ");
        int p = int.Parse(Console.ReadLine());
        // Calculate
        bool hasOneAtGivenBitPosition = (((v >> p) & 1) == 1);
        // Output data
        Console.WriteLine("v={0}; p={1} -> {2}", v, p, hasOneAtGivenBitPosition);
    }
}