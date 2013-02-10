/*
Problem 5 – Liquid
You are given a rectangular cuboid of size W (width), H (height) and D (depth) consisting
of W * H * D cubes, each containing an integer number specifying its capacity – how much
liquids can pass through the cube per fixed unit of time (a non-negative integer number).
Two cubes are neighbors if they share the same side. There are holes with unlimited capacity
at the top side of all cubes staying at the top side of the cuboid. There are also holes
with unlimited capacity at the bottom side of all cubes staying at the bottom side of the cuboid.
Suppose we have an unlimited supply of liquid spilled at the top of the cuboid and that the
liquid can pass freely from one cube to all its neighbors except the cube above it. Your task
is to write a program which calculates the amount of liquid that could pass from the top side
of the cuboid through the top holes through its cubes to the bottom side of the cuboid and
then outside of it through the bottom holes.
Input
The input data should be read from the console. At the first line 3 integers W, H and D are
given separated by a space. These numbers specify the width, height and depth of the cuboid.
At the next H lines the colors of the cubes in the cuboid are given as D sequences of 
exactly W integers. Each of these sequences consists of W integers separated by a single
space. The sequences of W integers are separated one from another by " | " (space + vertical line + space).
The input data will be correct and there is no need to check it explicitly.
Output
The output data should be printed on the console.
At the first line of the output print the amount of liquid that can pass from the cuboid's
top side to the cuboid's bottom side.
Constraints
- The numbers W, H and D are integers in the range [1…15].
- The integers in the cuboid are in the range [0…100]
- Allowed work time for your program: 0.5 seconds.
- Allowed memory: 64 MB.
*/

using System;

class Liquid
{
    static void Main()
    {
        Liquid c = new Liquid();
        Console.WriteLine(c.Capacity());
    }

    public int W, H, D;

    public int[, ,] Cubes;
    public bool[, ,] VisitedCubes;

    public Liquid()
    {
        string[] firstInputLine = Console.ReadLine().Split(' ');
        W = int.Parse(firstInputLine[0]);
        H = int.Parse(firstInputLine[1]);
        D = int.Parse(firstInputLine[2]);
        Cubes = new int[H, W, D];
        VisitedCubes = new bool[H, W, D];
        for (int row = 0; row < H; row++)
        {
            string[] nextInputLine = Console.ReadLine().Split('|');
            for (int level = 0; level < D; level++)
            {
                string[] nextCube = nextInputLine[level].Trim().Split(' ');
                for (int column = 0; column < W; column++)
                {
                    Cubes[row, column, level] = int.Parse(nextCube[column]);
                }
            }
        }
    }

    public bool IsPassable(int row, int column, int level)
    {
        if (row < 0 || row >= H || column < 0 || column >= W || level < 0 ||
            level >= D)
        {
            return false;
        }
        if (Cubes[row, column, level] == 0)
        {
            return false;
        }
        if (VisitedCubes[row, column, level])
        {
            return false;
        }
        if (level == D - 1)
        {
            Cubes[row, column, level]--;
            VisitedCubes[row, column, level] = false;
            return true;
        }
        VisitedCubes[row, column, level] = true;
        if (IsPassable(row, column, level + 1))
        {
            Cubes[row, column, level]--;
            VisitedCubes[row, column, level] = false;
            return true;
        }
        if (level > 0)
        {
            if (IsPassable(row - 1, column, level))
            {
                Cubes[row, column, level]--;
                VisitedCubes[row, column, level] = false;
                return true;
            }
            if (IsPassable(row + 1, column, level))
            {
                Cubes[row, column, level]--;
                VisitedCubes[row, column, level] = false;
                return true;
            }
            if (IsPassable(row, column - 1, level))
            {
                Cubes[row, column, level]--;
                VisitedCubes[row, column, level] = false;
                return true;
            }
            if (IsPassable(row, column + 1, level))
            {
                Cubes[row, column, level]--;
                VisitedCubes[row, column, level] = false;
                return true;
            }
        }
        VisitedCubes[row, column, level] = false;
        return false;
    }

    public int Capacity()
    {
        int capacity = 0;
        for (int row = 0; row < H; row++)
        {
            for (int column = 0; column < W; column++)
            {
                while (IsPassable(row, column, 0))
                {
                    capacity++;
                }
            }
        }
        return capacity;
    }
}
