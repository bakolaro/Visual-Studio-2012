using System;

class PointInCircle
{
    static void Main()
    {
        // Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
        Console.Write("Point, x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Point, y = ");
        double y = double.Parse(Console.ReadLine());
        bool isWithinTheCircle = ((x * x + y * y) <= 25.0);
        Console.WriteLine("Point ({0}, {1}) is within K(O, 5). {2}.", x, y, isWithinTheCircle);
    }
}