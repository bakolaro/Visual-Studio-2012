using System;
using System.Globalization;
using System.Threading;

class ShowSignOfThreeVarsProduct
{
    static void Main()
    {
        /* Write a program that shows the sign (+ or -) of the product of three real 
         * numbers without calculating it. Use a sequence of if statements.
         */
        // Set <decimal point> = <dot>
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        // About
        Console.WriteLine("Show the sign of product of 3 real numbers:");
        // Input data
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());
        Console.Write("z = ");
        double z = double.Parse(Console.ReadLine());
        // Calculate
        bool isPositive = IsPositive(x, y, z);
        // Output data
        Console.WriteLine(isPositive ? "The sign is (+)." : "The sign is (-).");
        // Test
        Console.WriteLine();
        Console.WriteLine("Test:");
        double[] values = new double[3]{-46.4, 0.0, 23.06};
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.WriteLine(values[i] * values[j] * values[k] < 0 ? "The sign is (-)." : "The sign is (+).");
                    Console.WriteLine(IsPositive(values[i], values[j], values[k]) ? "The sign is (+)." : "The sign is (-).");
                    Console.WriteLine();
                }
            }
        }
    }

    static bool IsPositive(double x, double y, double z)
    {
        if (x < 0)
        {
            if (y < 0)
            {
                if (z < 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (y > 0)
            {
                if (z <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        else if (x > 0)
        {
            if (y < 0)
            {
                if (z <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (y > 0)
            {
                if (z < 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }
        else
        {
            return true;
        }
    }
}