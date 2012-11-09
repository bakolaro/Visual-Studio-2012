using System;

class PointInCircle
{
	static void Main()
    {
        // Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

        // About
        Console.WriteLine("Point within circle K(O, 5)");
        // Input data
        Console.Write("Point, x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Point, y = ");
        double y = double.Parse(Console.ReadLine());
        // Calculate
        bool isWithinTheCircle = ((x * x + y * y) <= 25.0);
        // Output data
        Console.WriteLine("Point ({0}, {1}) is within K(O, 5). {2}.", x, y, isWithinTheCircle);
    }
}