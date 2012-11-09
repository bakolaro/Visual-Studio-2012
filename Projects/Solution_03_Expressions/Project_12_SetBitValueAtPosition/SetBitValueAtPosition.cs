using System;

class SetBitValueAtPosition
{
	static void Main()
    {
        // We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence 
        // of operators that modifies n to hold the value v at the position p from the binary
        // representation of n.
        // Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101)
        // n = 5 (00000101), p=2, v=0 -> 1 (00000001)

        // About
        Console.WriteLine("Set bit value at position");
        // Input data
        Console.Write("Integer, n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Bit position, p = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Bit value, v {0, 1} = ");
        int v = int.Parse(Console.ReadLine());
        // Calculate
        int newValue = n & ~(1 << p) | (v << p);
        // Output data
        Console.WriteLine("n = {0} ({1}), p={2}, v={3} -> {4} ({5})",
            n, Convert.ToString(n, 2), p, v, newValue, Convert.ToString(newValue, 2));
        // Test
        Console.WriteLine("Test");
        n = 5;
        p = 3;
        v = 1;
        newValue = n & ~(1 << p) | (v << p);
        Console.WriteLine("n = {0} ({1}), p={2}, v={3} -> {4} ({5})",
            n, Convert.ToString(n, 2).PadLeft(8,'0'), p, v, newValue, Convert.ToString(newValue, 2).PadLeft(8,'0'));
        Console.WriteLine("n = 5 (00000101), p=3, v=1 -> 13 (00001101)");
        n = 5;
        p = 2;
        v = 0;
        newValue = n & ~(1 << p) | (v << p);
        Console.WriteLine("n = {0} ({1}), p={2}, v={3} -> {4} ({5})",
            n, Convert.ToString(n, 2).PadLeft(8,'0'), p, v, newValue, Convert.ToString(newValue, 2).PadLeft(8,'0'));
        Console.WriteLine("n = 5 (00000101), p=2, v=0 -> 1 (00000001)");
    }
}