using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        // Set <decimal point> = <dot>
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        // Input data
        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        // Calculate
        double a = n / (1 - 128.523123123 * (p / n));
        double b = 1 / (m * p * (n - 128.523123123 * p));
        double c = 1337 / (n - 128.523123123 * p);
        
        double remainder = m - 180 * Math.Truncate(m / 180);
        double mod = Math.Truncate(remainder);
        double sin = Math.Sin(mod);

        double result = a + b + c +sin;
        // Output data
        Console.WriteLine("{0:F6}", result);
    }
}
