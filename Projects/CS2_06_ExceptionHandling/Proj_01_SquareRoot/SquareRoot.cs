using System;

class SquareRoot
{
    /* Write a program that reads an integer number and calculates and
     * prints its square root. If the number is invalid or negative, 
     * print "Invalid number". In all cases finally print "Good bye". 
     * Use try-catch-finally.
     */
    static void Main()
    {
        try
        {
            Console.Write("Integer, n = ");
            ulong n = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Sqrt({0}) = {1:f4}", n, Math.Sqrt(n));
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}