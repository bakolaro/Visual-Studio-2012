using System;

class FighterAttack
{
    static void Main()
    {
        // Input data
        int p1x = int.Parse(Console.ReadLine());
        int p1y = int.Parse(Console.ReadLine());
        int p2x = int.Parse(Console.ReadLine());
        int p2y = int.Parse(Console.ReadLine());
        int fx = int.Parse(Console.ReadLine());
        int fy = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        // Calculate
        int damage = 0;
        // Damaged cells
        Point hit = new Point(fx + d, fy);
        Point left = new Point(fx + d, fy + 1);
        Point right = new Point(fx + d, fy - 1);
        Point front = new Point(fx + d + 1, fy);
        // Plant corner cells
        Point c1 = new Point(p1x, p1y);
        Point c2 = new Point(p2x, p2y);
        if (causesDamage(hit, c1, c2))
        {
            damage += 100;
        }
        if (causesDamage(left, c1, c2))
        {
            damage += 50;
        }
        if (causesDamage(right, c1, c2))
        {
            damage += 50;
        }
        if (causesDamage(front, c1, c2))
        {
            damage += 75;
        }
        // Output data
        Console.WriteLine(damage + "%");
    }

    struct Point
    {
        public int X, Y;

        public Point(int px, int py)
        {
            X = px;
            Y = py;
        }
    }

    static bool causesDamage(Point f, Point plantCorner1, Point plantCorner2)
    {
        if((f.X - plantCorner1.X) * (f.X - plantCorner2.X) > 0)
        {
            return false;
        }
        if ((f.Y - plantCorner1.Y) * (f.Y - plantCorner2.Y) > 0)
        {
            return false;
        }
        return true;
    }
}