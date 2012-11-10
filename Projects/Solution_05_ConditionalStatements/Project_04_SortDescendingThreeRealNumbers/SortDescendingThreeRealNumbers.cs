using System;

class SortDescendingThreeRealNumbers
{
    static void Main()
    {
        /* Sort 3 real values in descending order using nested if statements. */

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
                // z > y > x
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

            }
            else
            {
                // x > y > z
                // do nothing;
            }
        }
    }
}
