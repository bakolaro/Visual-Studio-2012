using System;

// Add reference to IOArrays (a class library in this solution)

public class ReverseDigits
{
    /* Write a method that reverses the digits of given decimal number.
     */
    public static void Main()
    {
        IOArrays.WriteInputFormatSpecification();
        string input = "ReverseDigits.in";
        Console.WriteLine(@"Input integer vectors from file (""bin/.../{0}"")", input);

        int[][] a = IOArrays.ReadIntVectorsFromFile(input);
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine("Set of numbers {0}.", i);
            IOArrays.WriteVector<int>(a[i]);
            Console.WriteLine("Digits in reverse order:");
            for (int j = 0; j < a[i].Length - 1; j++)
            {
                Console.Write("{0} ", ReverseIntegerDigits(a[i][j]));
            }
            Console.WriteLine("{0}", ReverseIntegerDigits(a[i][a[i].Length - 1]));
            Console.WriteLine();
        }
    }
    public static int ReverseIntegerDigits(int x)
    {
        int y = 0;
        while (x != 0)
        {
            y *= 10;
            y += x % 10;
            x /= 10;
        }
        return y;
    }
}
