using System;

class ReadValidIntegers
{
    /* Write a method ReadNumber(int start, int end) that enters
     * an integer number in given range [start…end]. If an invalid
     * number or non-number text is entered, the method should
     * throw an exception. Using this method write a program that
     * enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
     */
    static void Main()
    {
        try
        {
            int[] a = new int[10];
            a[0] = ReadNumber(2, 90);
            for (int i = 1; i < a.Length; i++)
            {
                a[i] = ReadNumber(a[i - 1] + 1, 90 + i);
            }
            Console.Write("1");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" < {0}", a[i]);
            }
            Console.WriteLine(" < 100");
        }
        catch (ValueOutOfRangeException rex)
        {
            Console.WriteLine("Invalid input! " + rex.Message);
        }
        catch (FormatException fex)
        {
            Console.WriteLine(fex.Message);
        }
    }
    public static int ReadNumber(int start, int end)
    {
        Console.Write("Enter a valid integer (from {0} to {1}) = ", start, end);
        int x = int.Parse(Console.ReadLine());
        if (x < start || x > end)
        {
            throw new ValueOutOfRangeException(start, end, x);
        }
        return x;
    }
    class ValueOutOfRangeException : ArgumentException
    {
        public ValueOutOfRangeException(int start, int end, int value)
            : base(string.Format("An argument ({0}) is out of range (from {1} to {2}).", value, start, end))
        {
        }
    }
}
