using System;

class Exchange2SequencesOfManyBits
{
    static void Main()
    {
        // * Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.
        Console.Write("Unsigned integer, uns = ");
        uint uns = uint.Parse(Console.ReadLine());
        Console.Write("First sequence of bits starts at position, p = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Second sequence of bits starts at position, q = ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Swap sequences length, k = ");
        int k = int.Parse(Console.ReadLine());
        if (p > q)
        {
            int swap = p;
            p = q;
            q = swap;
        }
        uint mask = ~((~0u) << k);
        uns = ((((mask << q) & uns) >> (q - p)) | (((mask << p) & uns) << (q - p))) | (uns & ~(mask << q) & ~(mask << p));
        Console.WriteLine("{0} ({1})", uns, Convert.ToString(uns, 2));
    }
}