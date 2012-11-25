using System;
using System.Globalization;
using System.Threading;

class PointInCircleAndOutOfRectangle
{
	static void Main()
    {
        // Write an expression that checks for given point (x, y) if it is within the 
        // circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
        // Set <decimal point> = <dot>
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        // About
        Console.WriteLine("Point within circle K and out of rectangle R");
        // Input data
        Console.Write("Point, x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Point, y = ");
        double y = double.Parse(Console.ReadLine());
        // Calculate
        bool isInCircleAndOutOfRectangle = ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 9 
            && (x < -1 || x > 5 || y < -1 || y > 1));
        // Output data
        Console.WriteLine("Point ({0}, {1}) is within K((1, 1), 3) " + 
            "and out of R(1, -1, 6, 2). {2}.", x, y, isInCircleAndOutOfRectangle);
    }
}