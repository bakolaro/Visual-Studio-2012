using System;

class CartesianCoordinateSystem
{
    static void Main()
    {
        // Input data
        long x = long.Parse(Console.ReadLine());
        long y = long.Parse(Console.ReadLine());
        // Calculate
        int numberOfLocation = 0;
        // -2 000 000 000 001 337
        //  2 000 000 000 001 337
        if (x == 0 && y == 0)
        {
            numberOfLocation = 0;
        }
        else if(x == 0 && y != 0)
        {
            numberOfLocation = 5;
        }
        else if (x != 0 && y == 0)
        {
            numberOfLocation = 6;
        }
        else if (x > 0 && y > 0)
        {
            numberOfLocation = 1;
        }
        else if (x < 0 && y < 0)
        {
            numberOfLocation = 3;
        }
        else if (x < 0 && y > 0)
        {
            numberOfLocation = 2;
        }
        else if (x > 0 && y < 0)
        {
            numberOfLocation = 4;
        }
        // Output data
        Console.WriteLine(numberOfLocation);
    }
}