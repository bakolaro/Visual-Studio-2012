using System;

class ShipDamage
{
    static void Main()
    {
        // Input data
        int sx1 = int.Parse(Console.ReadLine());
        int sy1 = int.Parse(Console.ReadLine());
        int sx2 = int.Parse(Console.ReadLine());
        int sy2 = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        int c1x = int.Parse(Console.ReadLine());
        int c1y = int.Parse(Console.ReadLine());
        int c2x = int.Parse(Console.ReadLine());
        int c2y = int.Parse(Console.ReadLine());
        int c3x = int.Parse(Console.ReadLine());
        int c3y = int.Parse(Console.ReadLine());
        // Calculate
        Ship s = new Ship(new Point(sx1, sy1), new Point(sx2, sy2));

        int p1x = c1x;
        int p1y = h + (h - c1y);
        int damage1 = ProjectileDamage(s, new Point(p1x, p1y));

        int p2x = c2x;
        int p2y = h + (h - c2y);
        int damage2 = ProjectileDamage(s, new Point(p2x, p2y));

        int p3x = c3x;
        int p3y = h + (h - c3y);
        int damage3 = ProjectileDamage(s, new Point(p3x, p3y));

        int damage = damage1 + damage2 + damage3;
        // Ouptut data
        Console.WriteLine(damage + "%");
    }

    struct Ship
    {
        public int x1, y1, x2, y2;

        public Ship(Point c1, Point c2)
        {
            x1 = c1.x;
            y1 = c1.y;
            x2 = c2.x;
            y2 = c2.y;
        }
    }

    struct Point
    {
        public int x, y;

        public Point(int px, int py)
        {
            x = px;
            y = py;
        }
    }

    static int ProjectileDamage(Ship s, Point projectile)
    {
        if ((s.x1 == projectile.x || s.x2 == projectile.x) &&
            (s.y1 == projectile.y || s.y2 == projectile.y))
        {
            return 25;
        }
        else if ((s.x1 == projectile.x || s.x2 == projectile.x) &&
            ((s.y1 - projectile.y) * (s.y2 - projectile.y) < 0) ||
            (s.y1 == projectile.y || s.y2 == projectile.y) &&
            ((s.x1 - projectile.x) * (s.x2 - projectile.x) < 0))
        {
            return 50;
        }
        else if (((s.y1 - projectile.y) * (s.y2 - projectile.y) < 0) &&
            ((s.x1 - projectile.x) * (s.x2 - projectile.x) < 0))
        {
            return 100;
        }
        else
        {
            return 0;
        }
    }
}