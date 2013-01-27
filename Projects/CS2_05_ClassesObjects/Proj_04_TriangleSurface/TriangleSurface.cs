using System;
using System.Globalization;
using System.Threading;

class TriangleSurface
{
    /* Write methods that calculate the surface of a triangle by given:
     * Side and an altitude to it; Three sides; Two sides and an angle
     * between them. Use System.Math.
     */
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Find surface of a triangle:");
        Console.Write("Side = ");
        double side = double.Parse(Console.ReadLine());
        Console.Write("Height = ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("Surface = {0:f4}",
            TriangleSurfaceBySideAndHeight(side, h));
        Console.WriteLine(new string('-', 40));

        Console.Write("Side 1 = ");
        double side1 = double.Parse(Console.ReadLine());
        Console.Write("Side 2 = ");
        double side2 = double.Parse(Console.ReadLine());
        Console.Write("Side 3 = ");
        double side3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Surface = {0:f4}",
            TriangleSurfaceByThreeSides(side1, side2, side3));
        Console.WriteLine(new string('-', 40));

        Console.Write("Side 1 = ");
        side1 = double.Parse(Console.ReadLine());
        Console.Write("Side 2 = ");
        side2 = double.Parse(Console.ReadLine());
        Console.Write("Angle between sides = ");
        double angle = double.Parse(Console.ReadLine());
        Console.WriteLine("Surface = {0:f4}",
            TriangleSurfaceByTwoSidesAndAngle(side1, side2, angle));
        Console.WriteLine(new string('-', 40));
    }
    public static dynamic TriangleSurfaceBySideAndHeight(double side, double height)
    {
        bool exists = (side >= 0) && (height >= 0);
        if (exists)
        {
            return side * height / 2;
        }
        return "non-existent";
    }
    public static dynamic TriangleSurfaceByThreeSides(double side1, double side2, double side3)
    {
        double p = (side1 + side2 + side3) / 2;
        bool exists = (p >= 0) && (p >= side1) && (p >= side2) && (p >= side3);
        if (exists)
        {
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }
        return "non-existent";
    }
    public static dynamic TriangleSurfaceByTwoSidesAndAngle(double side1, double side2, double angle)
    {
        bool exists = (side1 >= 0) && (side2 >= 0) && (Math.Sin(angle) >= 0);
        if(exists)
        {
            return side1 * side2 * Math.Sin(angle) / 2;
        }
        return "non-existent";
    }
}