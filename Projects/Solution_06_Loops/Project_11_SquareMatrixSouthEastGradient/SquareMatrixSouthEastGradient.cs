using System;

class SquareMatrixSouthEastGradient
{
    static void Main()
    {
        /* Write a program that reads from the console a positive integer
         * number N (N < 20) and outputs a matrix like the following:
         * N = 3			N = 4
         *   1  2  3          1  2  3  4
         *   2  3  4          2  3  4  5
         *   3  4  5          3  4  5  6
         *                    4  5  6  7
         */

        // About
        Console.WriteLine("Display a matrix of numbers, growing to South-East:");
        // Input data
        Console.Write("n (n < 20) = ");
        int n = int.Parse(Console.ReadLine());
        // Validate input
        if (n < 1 || n > 19)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        // Calculate
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = i + j + 1;
            }
        }
        // Output data
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

