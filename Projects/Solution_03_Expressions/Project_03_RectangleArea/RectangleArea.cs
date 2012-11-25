using System;
using System.Globalization;
using System.Threading;

class RectangleArea
{
	static void Main()
    {
        // Write an expression that calculates rectangle’s area by given width
        // and height.
        // Set <decimal point> = <dot>
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        // About
        Console.WriteLine("Rectangle Area");
        // Input data
        Console.Write("Rectangle, width = ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Rectangle, height = ");
        double height = double.Parse(Console.ReadLine());
        // Calculate
        double area = width * height;
        // Output data
        Console.WriteLine("Rectangle, area = {0,4}", area);
    }
}