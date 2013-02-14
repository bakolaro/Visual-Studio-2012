using System;
using System.IO;

public struct Lines
{
    public int Length, Count;
    public void Print()
    {
        if (Length > 1)
        {
            Console.WriteLine("{0} {1}", Length, Count);
        }
        else
        {
            Console.WriteLine(-1);
        }
    }
}
public class Lines3D
{
    public struct Coords
    {
        private Lines3D parent;
        public int Height, Depth, Width;
        public Coords(Lines3D parent, int h, int d, int w)
        {
            this.parent = parent;
            Height = h;
            Depth = d;
            Width = w;
        }
        public bool Plus(Coords coords)
        {
            char color = parent.Cuboid[Height, Depth, Width];
            Height += coords.Height;
            Depth += coords.Depth;
            Width += coords.Width;
            if (Height >= 0 &&
                Depth >= 0 &&
                Width >= 0 &&
                Height < parent.Cuboid.GetLength(0) &&
                Depth < parent.Cuboid.GetLength(1) &&
                Width < parent.Cuboid.GetLength(2) &&
                color == parent.Cuboid[Height, Depth, Width])
            {
                return true;
            }
            else
            {
                Height -= coords.Height;
                Depth -= coords.Depth;
                Width -= coords.Width;
                return false;
            }
        }
        public bool Minus(Coords coords)
        {
            char color = parent.Cuboid[Height, Depth, Width];
            Height -= coords.Height;
            Depth -= coords.Depth;
            Width -= coords.Width;
            if (Height >= 0 &&
                Depth >= 0 &&
                Width >= 0 &&
                Height < parent.Cuboid.GetLength(0) &&
                Depth < parent.Cuboid.GetLength(1) &&
                Width < parent.Cuboid.GetLength(2) &&
                color == parent.Cuboid[Height, Depth, Width])
            {
                return true;
            }
            else
            {
                Height += coords.Height;
                Depth += coords.Depth;
                Width += coords.Width;
                return false;
            }
        }
    }
    public char[, ,] Cuboid;
    public bool[, , ,] Visited;
    public int H, D, W;
    static void Main()
    {
        Lines3D x = new Lines3D();
        Lines max = new Lines();
        max.Count = 0;
        max.Length = 0;
        for (int h = 0; h < x.H; h++)
        {
            for (int d = 0; d < x.D; d++)
            {
                for (int w = 0; w < x.W; w++)
                {
                    Lines local = x.GetLongestLines(h, d, w);
                    if (max.Length < local.Length)
                    {
                        max.Length = local.Length;
                        max.Count = local.Count;
                    }
                    else if (max.Length == local.Length)
                    {
                        max.Count += local.Count;
                    }
                }
            }
        }
        max.Print();
    }
    public Lines3D()
    {
#if DEBUG
        Console.SetIn(new StreamReader("Test2.txt"));
#endif
        string[] dims = Console.ReadLine().Split();
        W = int.Parse(dims[0]);
        H = int.Parse(dims[1]);
        D = int.Parse(dims[2]);
        Cuboid = new char[H, D, W];
        Visited = new bool[H, D, W, 13];
        for (int h = 0; h < H; h++)
        {
            string wall = Console.ReadLine();
            string[] sequences = wall.Split();
            for (int d = 0; d < sequences.Length; d++)
            {
                string cubes = sequences[d];
                for (int w = 0; w < cubes.Length; w++)
                {
                    Cuboid[h, d, w] = cubes[w];
                }
            }
        }
    }
    public Lines GetLongestLines(int h, int d, int w)
    {
        // check all 13 directions
        Coords here = new Coords(this, h, d, w);
        Coords[] directions = new Coords[]{
            new Coords(this, 1, 0, 0),
            new Coords(this, 0, 1, 0),
            new Coords(this, 0, 0, 1),
            new Coords(this, 1, 1, 0),
            new Coords(this, 1, 0, 1),
            new Coords(this, 0, 1, 1),
            new Coords(this, 1, -1, 0),
            new Coords(this, 1, 0, -1),
            new Coords(this, 0, 1, -1),
            new Coords(this, 1, 1, 1),
            new Coords(this, 1, -1, -1),
            new Coords(this, -1, 1, -1),
            new Coords(this, 1, 1, -1),};
        Lines max = new Lines();
        max.Count = 0;
        max.Length = 0;
        for (int i = 0; i < directions.Length; i++)
        {
            Coords n = here;
            if (!Visited[h, d, w, i])
            {
                Visited[h, d, w, i] = true;
                int length = 1;
                while (n.Plus(directions[i]))
                {
                    Visited[n.Height, n.Depth, n.Width, i] = true;
                    length++;
                }
                n = here;
                while (n.Minus(directions[i]))
                {
                    Visited[n.Height, n.Depth, n.Width, i] = true;
                    length++;
                }
                if (max.Length < length)
                {
                    max.Length = length;
                    max.Count = 1;
                }
                else if (max.Length == length)
                {
                    max.Count++;
                }
            }
        }
        return max;
    }
}