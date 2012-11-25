using System;

class GetBitValueAtPosition
{
	static void Main()
    {
        // Write an expression that extracts from a given integer i the value of
        // a given bit number b. Example: i=5; b=2 -> value=1.

        // About
        Console.WriteLine("");
        // Input data
        Console.Write("Integer, i = ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Bit position, b (0 <= b <= 31) = ");
        int b = int.Parse(Console.ReadLine());
        // Calculate
        int value = ((i >> b) & 1);
        // Output data
        Console.WriteLine("i={0}; b={1} -> value={2}", i, b, value);
    }
}