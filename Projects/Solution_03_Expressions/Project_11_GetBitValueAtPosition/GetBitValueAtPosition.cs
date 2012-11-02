using System;

class GetBitValueAtPosition
{
    static void Main()
    {
        // Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2 ? value=1.
        Console.Write("Integer, i = ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Bit position, bp (0 ? bp ? 31) = ");
        int bp = int.Parse(Console.ReadLine());
        int value = ((i >> bp) & 1);
        Console.WriteLine("In {0} value of bit at position {1} is {2}.", i, bp, value);
    }
}