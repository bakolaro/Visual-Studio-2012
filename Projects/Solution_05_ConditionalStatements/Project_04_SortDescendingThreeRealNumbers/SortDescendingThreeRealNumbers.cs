using System;
using System.Globalization;
using System.Threading;

class SortDescendingThreeRealNumbers
{
    static void Main()
    {
        /* Sort 3 real values in descending order using nested if statements. */
        
        // Set <decimal point> = <dot>
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        // About
        Console.WriteLine("Sort 3 real numbers:");
        // Input data
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());
        Console.Write("z = ");
        double z = double.Parse(Console.ReadLine());
        // Calculate
        double swap;
        if (x < y)
        {
            if (y < z)
            {
                // i.e. z > y > x
                swap = x;
                x = z;
                z = swap;
            }
            else if (x < z)
            {
                // y > z > x
                swap = x;
                x = y;
                y = z;
                z = swap;
            }
            else
            {
                // y > x > z
                swap = x;
                x = y;
                y = swap;
            }
        }
        else
        {
            if (x < z)
            {
                // z > x > y
                swap = x;
                x = z;
                z = y;
                y = swap;
            }
            else if (y < z)
            {
                // x > z > y
                swap = z;
                z = y;
                y = swap;
            }
            else
            {
                // x > y > z
                // do nothing;
            }
        }
        // Output data
        Console.WriteLine("{0:F4} > {1:F4} > {2:F4}", x, y, z);
    }
}
