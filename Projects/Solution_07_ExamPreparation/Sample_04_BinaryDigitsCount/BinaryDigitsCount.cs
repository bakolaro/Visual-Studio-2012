using System;

class BinaryDigitsCount
{
    static void Main()
    {
        // Input data
        int b = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        uint[] a = new uint[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = uint.Parse(Console.ReadLine());
        }
        // Calculate
        int[] digits = new int[n];
        for (int i = 0; i < n; i++)
        {
            uint temp;
            if (b > 0)
            {
                temp = a[i];
            }
            else
            {
                temp = ~a[i];
            }
            for (int j = 0; j < 32; j++)
            {
                // Do not count leading zeros
                if ((a[i] >> j) == 0u)
                {
                    break;
                }
                else
                {
                    digits[i] += (int)((temp >> j) & 1u);
                }
            }
        }
        // Output data
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(digits[i]);
        }
    }
}
