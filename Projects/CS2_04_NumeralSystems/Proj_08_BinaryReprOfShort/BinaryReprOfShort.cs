using System;
using System.Text;

public class BinaryReprOfShort
{
    public static void Main()
    {
        Console.Write("A short integer, n = ");
        short n = short.Parse(Console.ReadLine());
        StringBuilder bin = new StringBuilder();
        // short is a 16-bit signed integer
        for (int i = 0; i < 16; i++)
        {
            if ((n & 1) == 0)
            {
                bin.Insert(0, '0');
            }
            else
            {
                bin.Insert(0, '1');
            }
            n >>= 1;
        }
        Console.WriteLine(bin);
    }
}

