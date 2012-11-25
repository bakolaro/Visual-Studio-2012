using System;
using System.Globalization;
using System.Threading;

class TrapezoidArea
{
	static void Main()
    {
        // Write an expression that calculates trapezoid's area by given sides a 
        // and b and height h.
        // Set <decimal point> = <dot>
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        // About
        Console.WriteLine("Trapezoid area");
        // Input data
        Console.Write("Trapezoid, a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Trapezoid, b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Trapezoid, h = ");
        double h = double.Parse(Console.ReadLine());
        // Calculate
        double area = (a + b) * h / 2;
        // Output data
        Console.WriteLine("Trapezoid, area = {0}", area);
    }
}