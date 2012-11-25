using System;

class Exchange2SequencesOf3Bits
{
	static void Main()
    {
        // Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of
        // given 32-bit unsigned integer.

    	// About
        Console.WriteLine("Exchange bits");
	    // Input data
        Console.Write("Unsigned integer, n = ");
        uint n = uint.Parse(Console.ReadLine());
        // Calculate
        uint select24 = 7u << 24;
        uint select3 = 7u << 3;
        uint copy24 = select24 & n;
        uint copy3 = select3 & n;
        uint clear = ~select24 & ~select3 & n;
        uint move24 = copy24 >> 21;
        uint move3 = copy3 << 21;
        uint paste = move24 | move3 | clear;
        // Output data
        Console.WriteLine();
        Console.WriteLine("{0,15} {1,15} ({2})", "n = ", n,
            Convert.ToString(n, 2).PadLeft(32, '0').Replace('0', '.'));
        Console.WriteLine("{0,15} {1,15} ({2})", "select24 = ", select24, 
            Convert.ToString(select24, 2).PadLeft(32, '0').Replace('0', '.'));
        Console.WriteLine("{0,15} {1,15} ({2})", "select3 = ", select3, 
            Convert.ToString(select3, 2).PadLeft(32, '0').Replace('0', '.'));
        Console.WriteLine("{0,15} {1,15} ({2})", "copy24 = ", copy24, 
            Convert.ToString(copy24, 2).PadLeft(32, '0').Replace('0', '.'));
        Console.WriteLine("{0,15} {1,15} ({2})", "copy3 = ", copy3, 
            Convert.ToString(copy3, 2).PadLeft(32, '0').Replace('0', '.'));
        Console.WriteLine("{0,15} {1,15} ({2})", "clear = ", clear, 
            Convert.ToString(clear, 2).PadLeft(32, '0').Replace('0', '.'));
        Console.WriteLine("{0,15} {1,15} ({2})", "move24 = ", move24, 
            Convert.ToString(move24, 2).PadLeft(32, '0').Replace('0', '.'));
        Console.WriteLine("{0,15} {1,15} ({2})", "move3 = ", move3, 
            Convert.ToString(move3, 2).PadLeft(32, '0').Replace('0', '.'));
        Console.WriteLine("{0,15} {1,15} ({2})", "paste = ", paste, 
            Convert.ToString(paste, 2).PadLeft(32, '0').Replace('0', '.'));
        Console.WriteLine();
        Console.WriteLine("n = {0}", paste);
    }
}