using System;

class FallDown
{
    static void Main()
    {
        // Input data
        int[] grid = new int[8];
        for (int i = 0; i < 8; i++)
        {
            grid[i] = int.Parse(Console.ReadLine());
        }
        // Calculate
        for (int j = 6; j >= 0; j--)
        {
            for (int i = j; i < 7; i++)
            {
                int fallingDown = grid[i] & ~grid[i + 1];
                grid[i] &= ~fallingDown;
                grid[i + 1] |= fallingDown;
            }
        }
        // Output data
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine(grid[i]);
        }
    }

    static void DrawGrid(int[] grid)
    {
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 7; j >= 0; j--)
            {
                if (((grid[i] >> j) & 1) == 1)
                {
                    Console.Write('x');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}