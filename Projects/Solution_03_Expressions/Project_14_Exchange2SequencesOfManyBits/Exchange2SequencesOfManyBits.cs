using System;

class Exchange2SequencesOfManyBits
{
	static void Main()
    {
        // * Write a program that exchanges bits {p, p+1, …, p+k-1) 
        // with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

        // About
        Console.WriteLine("Exchange Sequences of Bits");

        // Input data
        Console.Write("Unsigned integer, n = ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("First sequence of bits starts at position, p (0 <= p < 31) = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Second sequence of bits starts at position, q ({0} < q <= 31) = ", p);
        int q = int.Parse(Console.ReadLine());
        Console.Write("Swap sequences with length, k (0 < k < {0}) = ", Math.Min(33 - q, q - p + 1));
        int k = int.Parse(Console.ReadLine());
        // Let p < q
        if ((q < p + 1) || (k < 1) || (q < k + p) || (q + k > 32) || (p < 0))
        {
            Console.WriteLine("Invalid data!");
            return;
        }
        // Calculate
        uint mask = ~((~0u) << k);
        uint selectQ = mask << q;
        uint selectP = mask << p;
        uint copyQ = selectQ & n;
        uint copyP = selectP & n;
        uint clear = ~selectQ & ~selectP & n;
        uint moveQ = copyQ >> (q - p);
        uint moveP = copyP << (q - p);
        uint paste = moveQ | moveP | clear;
        // Output data
        Console.WriteLine();
        Console.WriteLine("{0,15} {1,15} ({2})", "n = ", n, 
            Convert.ToString(n, 2).PadLeft(32, '0').Replace('0', '.'));
        Console.WriteLine("{0,15} {1,15} ({2})", "selectQ = ", selectQ, 
            Convert.ToString(selectQ, 2).PadLeft(32, '0').Replace('0', '.'));
        Console.WriteLine("{0,15} {1,15} ({2})", "selectP = ", selectP, 
            Convert.ToString(selectP, 2).PadLeft(32, '0').Replace('0', '.'));
        Console.WriteLine("{0,15} {1,15} ({2})", "copyQ = ", copyQ, 
            Convert.ToString(copyQ, 2).PadLeft(32, '0').Replace('0', '.'));
        Console.WriteLine("{0,15} {1,15} ({2})", "copyP = ", copyP, 
            Convert.ToString(copyP, 2).PadLeft(32, '0').Replace('0', '.'));
        Console.WriteLine("{0,15} {1,15} ({2})", "clear = ", clear, 
            Convert.ToString(clear, 2).PadLeft(32, '0').Replace('0', '.'));
        Console.WriteLine("{0,15} {1,15} ({2})", "moveQ = ", moveQ, 
            Convert.ToString(moveQ, 2).PadLeft(32, '0').Replace('0', '.'));
        Console.WriteLine("{0,15} {1,15} ({2})", "moveP = ", moveP, 
            Convert.ToString(moveP, 2).PadLeft(32, '0').Replace('0', '.'));
        Console.WriteLine("{0,15} {1,15} ({2})", "paste = ", paste, 
            Convert.ToString(paste, 2).PadLeft(32, '0').Replace('0', '.'));
        Console.WriteLine();
        Console.WriteLine("n = {0}", paste);
    }
}