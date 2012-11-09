using System;

class SolveCircle
{
    static void Main()
    {
        // Write a program that reads the radius r of a circle and prints its perimeter and area.

        // About
        Console.WriteLine("Input radius and calculate perimeter and area of a circle...");
        // Input data
        Console.Write("Radius = ");
        double radius = double.Parse(Console.ReadLine());
        // Calculate
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;
        // Output data
        Console.WriteLine("A circle with radius = {0} has perimeter = {1:0.00} and area = {2:0.00}.", radius, perimeter, area);
    }
}
