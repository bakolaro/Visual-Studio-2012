using System;

class TriangleSurface
{
    /* Write methods that calculate the surface of a triangle by given:
        * Side and an altitude to it; Three sides; Two sides and an angle
        * between them. Use System.Math.
        */
    static void Main()
    {
        Console.WriteLine("Find surface of a triangle:");
        Console.Write("Side = ");
        double side = double.Parse(Console.ReadLine());
        Console.Write("Height = ");
        double h = double.Parse(Console.ReadLine());
        TriangleSurface s = new TriangleSurface(side, h);
        Console.WriteLine("Surface = {0:f4}", s);
        Console.WriteLine(new string('-', 40));
        Console.Write("Side 1 = ");
        double side1 = double.Parse(Console.ReadLine());
        Console.Write("Side 2 = ");
        double side2 = double.Parse(Console.ReadLine());
        Console.Write("Side 3 = ");
        double side3 = double.Parse(Console.ReadLine());
        s = new TriangleSurface(side1, side2, side3);
        Console.WriteLine("Surface = {0:f4}", s);
        Console.WriteLine(new string('-', 40));
        Console.Write("Side 1 = ");
        side1 = double.Parse(Console.ReadLine());
        Console.Write("Side 2 = ");
        side2 = double.Parse(Console.ReadLine());
        Console.Write("Angle between sides = ");
        double angle = double.Parse(Console.ReadLine());
        s = new TriangleSurface(side1, side2, angle);
        Console.WriteLine("Surface = {0:f4}", s);
        Console.WriteLine(new string('-', 40));
    }
    public double Value;
    public TriangleSurface(double side, double height)
    {
        this.Value = side * height / 2;
    }
    public TriangleSurface(double side1, double side2, double side3)
    {
       // this.Value = side * height / 2;
    }
    public TriangleSurface(double side1, double side2, double angle)
    {
        this.Value = side1 * side2 * Math.Cos(angle);
    }
}