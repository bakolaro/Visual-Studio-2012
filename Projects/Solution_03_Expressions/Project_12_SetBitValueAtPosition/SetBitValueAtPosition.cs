using System;

class SetBitValueAtPosition
{
    static void Main()
    {
        // We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n 
        // to hold the value v at the position p from the binary representation of n.
        // Example: n = 5 (00000101), p=3, v=1 ? 13 (00001101)
        // n = 5 (00000101), p=2, v=0 ? 1 (00000001)
        Console.Write("Integer, n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Bit value, v {0, 1} = ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Bit position, p = ");
        int p = int.Parse(Console.ReadLine());
        n = n | (v << p);
        Console.WriteLine("{0} ({1})", n, Convert.ToString(n, 2));
    }
}