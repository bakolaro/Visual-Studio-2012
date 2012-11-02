using System;

class TrapezoidArea
{
    static void Main()
    {
        // Write an expression that calculates trapezoid's area by given sides a and b and height h.
        Console.Write("Trapezoid, a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Trapezoid, b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Trapezoid, h = ");
        double h = double.Parse(Console.ReadLine());
        double area = (a + b) * h / 2;
        Console.WriteLine("Trapezoid, area = {0}", area);
    }
}