using System;

class SquareMatrixSpiralGradient
{
    static void Main()
    {
        /* Write a program that reads a positive integer number N (N < 20)
         * from console and outputs in the console the numbers 1 ... N 
         * numbers arranged as a spiral.
         * Example for N = 4
         *    1  2  3  4
         *    12 13 14 5
         *    11 16 15 6
         *    10 9  8  7
         */

        // About
        Console.WriteLine("Display a matrix of numbers, growing in a spiral:");
        // Input data
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        // Validate input
        if (n < 1 || n > 19)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        // Calculate
        // Playing field
        int[,] matrix = new int[n + 2, n + 2];
        // Boundaries
        for (int i = 0; i < n + 2; i++)
        {
            matrix[i, 0] = -1;
            matrix[i, n + 1] = -1;
            matrix[0, i] = -1;
            matrix[n + 1, i] = -1;
        }
        // Starting point
        int row = 1;
        int column = 1;
        // Initial direction
        int dx = 1;
        int dy = 0;
        // Go
        for (int i = 1; i <= n * n; i++)
        {
            matrix[row, column] = i;
            // Next step
            row += dy;
            column += dx;
            // If not available
            if (matrix[row, column] != 0)
            {
                // Step back
                row -= dy;
                column -= dx;
                // Change direction
                if (dy == 0)
                {
                    dy = dx;
                    dx = 0;
                }
                else if (dx == 0)
                {
                    dx = -dy;
                    dy = 0;
                }
                // Repeat next step in the new direction
                row += dy;
                column += dx;
            }
        }
        // Output data
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

