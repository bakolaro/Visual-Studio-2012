using System;

class RectangleArea
{
    static void Main()
    {
        // Write an expression that calculates rectangle’s area by given width and height.
        Console.Write("Rectangle, width = ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Rectangle, height = ");
        double height = double.Parse(Console.ReadLine());
        double area = width * height;
        Console.WriteLine("Rectangle, area = {0,4}", area);
    }
}