using System;

class GetBit3
{
    static void Main()
    {
        // Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
        Console.Write("Integer, n = ");
        int n = int.Parse(Console.ReadLine());
        int bit3 = (n >> 3) & 1;
        Console.WriteLine("The third bit (right-to-left) of {0} is {1}.", n, bit3);
    }
}