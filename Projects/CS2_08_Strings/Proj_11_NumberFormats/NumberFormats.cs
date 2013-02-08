using System;
using System.Threading;
using System.Globalization;

/* Write a program that reads a number and prints it 
 * as a decimal number, hexadecimal number, percentage and
 * in scientific notation. Format the output aligned
 * right in 15 symbols.
 */
class NumberFormats
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Input a real number = ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("01234567890123456789");
        Console.WriteLine("{0,15:n}", x);
        Console.WriteLine("{0,15:x} (integral part)", (int)x);
        Console.WriteLine("{0,15:p}", x);
        Console.WriteLine("{0,15:e}", x);
    }
}