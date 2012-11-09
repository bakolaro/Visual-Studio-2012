using System;

class GetBit3
{
	static void Main()
    {
        // Write a boolean expression for finding if the bit 3 (counting from 0) of 
        // a given integer is 1 or 0.
        
        // About
        Console.WriteLine("Check if bit 3 is 1 or 0.");
        // Input data
        Console.Write("Integer, n = ");
        int n = int.Parse(Console.ReadLine());
        // Calculate
        int bit3 = (n >> 3) & 1;
        // Output data
        Console.WriteLine("The third bit (right-to-left) of {0} is {1}.", n, bit3);
    }
}