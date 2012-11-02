using System;

class Exchange2SequencesOf3Bits
{
    static void Main()
    {
        // Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
        Console.Write("Unsigned integer, uns = ");
        uint uns = uint.Parse(Console.ReadLine());
        uns = ((((111u << 24) & uns) >> 21) | (((111u << 3) & uns) << 21)) | (uns & ~(111u << 24) & ~(111u << 3));
        Console.WriteLine("{0} ({1})", uns, Convert.ToString(uns, 2));
    }
}