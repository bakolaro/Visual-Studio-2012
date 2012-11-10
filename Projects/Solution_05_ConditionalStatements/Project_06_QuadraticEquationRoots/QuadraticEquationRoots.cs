using System;

class QuadraticEquationRoots
{
    static void Main()
    {
        /* Write a program that enters the coefficients a, b and c of a quadratic
         * equation a*x2 + b*x + c = 0 and calculates and prints its real roots. 
         * Note that quadratic equations may have 0, 1 or 2 real roots.
         */

        // About
        Console.WriteLine("Solve a quadratic equation:");
        // Input data
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        // Calculate and output data
        double discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            Console.WriteLine("No real roots!");
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("One real root: x1 = x2 = {0}", x);
        }
        else
        {
            double x1 = -(b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
        }
    }
}

