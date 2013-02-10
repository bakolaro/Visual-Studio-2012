/*
Problem 4 – 3D Max Walk
You are given a rectangular cuboid of size W (width), H (height) and D (depth) consisting
of W * H * D cubes, each containing an integer number. A 3D max walk in the cuboid starts
from the cube located at the cuboid's center (W, H and D are odd numbers). At each step
the walk continues from the current cube in one of the 6 possible directions (left,
right, up, down, deeper, shallower) to the cube which holds the maximal value among all
possible cubes different than the current. The walk stops at some of the following conditions:
- Several cubes hold the same maximal value.
- There is only cube holding the maximal value but it is already visited (falls into a loop).
Your task is to write a program that finds the sum of the numbers in the cubes that are
visited during the 3D max walk.
Input
The input data should be read from the console. At the first line 3 integers W, H and D
are given separated by a space. These numbers specify the width, height and depth of the
cuboid. At the next H lines the colors of the cubes in the cuboid are given as D sequences
of exactly W integers. Each of these sequences consists of W integers separated by a single
space. The sequences of W integers are separated one from another by " | " (space + vertical line + space).
The input data will be correct and there is no need to check it explicitly.
Output
The output data should be printed on the console.
At the first line of the output print the sum of the cubes visited by the 3D max walk.
Constraints
- The numbers W, H and D are odd integers in the range [1…101].
- The integers in the cuboid are in the range [-1000…1000]
- Allowed work time for your program: 0.3 seconds.
- Allowed memory: 16 MB.
*/

using System;

class MaxWalk3D
{
    public int?[, ,] Cuboid;
    public bool[, ,] Visited;
    public int H, D, W;
    public int? MaxSum;
    static void Main()
    {
        MaxWalk3D c = new MaxWalk3D();
        c.Walk();
        Console.WriteLine(c.MaxSum);
    }
    public MaxWalk3D()
    {
        string[] dims = Console.ReadLine().Split();
        W = int.Parse(dims[0]);
        H = int.Parse(dims[1]);
        D = int.Parse(dims[2]);
        Cuboid = new int?[H, D, W];
        Visited = new bool[H, D, W];
        for (int h = 0; h < H; h++)
        {
            string wall = Console.ReadLine();
            string[] sequences = wall.Split('|');
            for (int d = 0; d < sequences.Length; d++)
            {
                string[] cubes = sequences[d].Trim().Split();
                for (int w = 0; w < cubes.Length; w++)
                {
                    Cuboid[h, d, w] = int.Parse(cubes[w]);
                }
            }
        }
    }
    public void Walk()
    {
        int h = H / 2;
        int d = D / 2;
        int w = W / 2;
        MaxSum = Cuboid[h, d, w];
        Visited[h, d, w] = true;
        int? maxLocal, maxDirection;
        int countMaxDirections;
        bool goOn;
        do
        {
            maxLocal = null;
            maxDirection = null;
            countMaxDirections = 0;
            goOn = false;
            int maxStep = 0;
            int x = 1;
            while (h - x >= 0)
            {
                if (maxLocal == null || Cuboid[h - x, d, w] > maxLocal)
                {
                    maxLocal = Cuboid[h - x, d, w];
                    maxDirection = 0;
                    countMaxDirections = 1;
                    maxStep = x;
                }
                else if (Cuboid[h - x, d, w] == maxLocal)
                {
                    countMaxDirections++;
                }
                x++;
            }
            x = 1;
            while (h + x <= H - 1)
            {
                if (maxLocal == null || Cuboid[h + x, d, w] > maxLocal)
                {
                    maxLocal = Cuboid[h + x, d, w];
                    maxDirection = 1;
                    countMaxDirections = 1;
                    maxStep = x;
                }
                else if (Cuboid[h + x, d, w] == maxLocal)
                {
                    countMaxDirections++;
                }
                x++;
            }
            x = 1;
            while (d - x >= 0)
            {
                if (maxLocal == null || Cuboid[h, d - x, w] > maxLocal)
                {
                    maxLocal = Cuboid[h, d - x, w];
                    maxDirection = 2;
                    countMaxDirections = 1;
                    maxStep = x;
                }
                else if (Cuboid[h, d - x, w] == maxLocal)
                {
                    countMaxDirections++;
                }
                x++;
            }
            x = 1;
            while (d + x <= D - 1)
            {
                if (maxLocal == null || Cuboid[h, d + x, w] > maxLocal)
                {
                    maxLocal = Cuboid[h, d + x, w];
                    maxDirection = 3;
                    countMaxDirections = 1;
                    maxStep = x;
                }
                else if (Cuboid[h, d + x, w] == maxLocal)
                {
                    countMaxDirections++;
                }
                x++;
            }
            x = 1;
            while (w - x >= 0)
            {
                if (maxLocal == null || Cuboid[h, d, w - x] > maxLocal)
                {
                    maxLocal = Cuboid[h, d, w - x];
                    maxDirection = 4;
                    countMaxDirections = 1;
                    maxStep = x;
                }
                else if (Cuboid[h, d, w - x] == maxLocal)
                {
                    countMaxDirections++;
                }
                x++;
            }
            x = 1;
            while (w + x <= W - 1)
            {
                if (maxLocal == null || Cuboid[h, d, w + x] > maxLocal)
                {
                    maxLocal = Cuboid[h, d, w + x];
                    maxDirection = 5;
                    countMaxDirections = 1;
                    maxStep = x;
                }
                else if (Cuboid[h, d, w + x] == maxLocal)
                {
                    countMaxDirections++;
                }
                x++;
            }
            if (countMaxDirections == 1)
            {
                switch (maxDirection)
                {
                    case 0: h -= maxStep; break;
                    case 1: h += maxStep; break;
                    case 2: d -= maxStep; break;
                    case 3: d += maxStep; break;
                    case 4: w -= maxStep; break;
                    case 5: w += maxStep; break;
                    default: return;
                }
                if(!Visited[h, d, w])
                {
                    Visited[h, d, w] = true;
                    MaxSum += Cuboid[h, d, w];
                    goOn = true;
                }
            }
        }
        while (goOn);
    }
}