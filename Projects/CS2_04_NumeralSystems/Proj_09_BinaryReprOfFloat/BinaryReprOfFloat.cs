﻿using System;
using System.Text;
using System.Threading;
using System.Globalization;

public class BinaryReprOfFloat
{
    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("A floating-point with single precision, x = ");
        float x = float.Parse(Console.ReadLine());
        // float is a 32-bit floating-point number
        int n = 0;
        unsafe
        {
            int* ptr = (int*)&x;
            n = *ptr;
        }
        StringBuilder bin = new StringBuilder();
        // int is 32-bit signed integer
        for (int i = 0; i < 32; i++)
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
        string str = bin.ToString();
        Console.WriteLine("sign = {0}, exponent = {1}, mantissa = {2}", str[0], str.Substring(1, 8), str.Substring(9));
    }
}
