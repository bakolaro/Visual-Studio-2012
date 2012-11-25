using System;
using System.Globalization;
using System.Threading;

class SolveCircle
{
    static void Main()
    {
        // Write a program that reads the radius r of a circle and prints its perimeter and area.
        // Set <decimal point> = <dot>
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        // About
        Console.WriteLine("Input a radius and calculate the perimeter and the area of a circle...");
        // Input data
        Console.Write("Radius = ");
        double radius = double.Parse(Console.ReadLine());
        // Calculate
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;
        // Output data
        Console.WriteLine("A circle with a radius of {0} has a perimeter of {1:0.00} and an area of {2:0.00}",
            radius, perimeter, area);
    }
}
