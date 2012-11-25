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
        public int X1, Y1, X2, Y2;

        public Ship(Point c1, Point c2)
        {
            X1 = c1.X;
            Y1 = c1.Y;
            X2 = c2.X;
            Y2 = c2.Y;
        }
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

    static int ProjectileDamage(Ship ship, Point projectile)
    {
        long dy1 = (ship.Y1 - projectile.Y);
        long dy2 = (ship.Y2 - projectile.Y);
        long dx1 = (ship.X1 - projectile.X);
        long dx2 = (ship.X2 - projectile.X);
        
        if ((dx1 * dx2 == 0L) && (dy1 * dy2 == 0L))
        {
            return 25;
        }
        else if ((dx1 * dx2 == 0L) && (dy1 * dy2 < 0L) || (dy1 * dy2 == 0L) && (dx1 * dx2 < 0L))
        {
            return 50;
        }
        else if ((dy1 * dy2 < 0L) && (dx1 * dx2 < 0L))
        {
            return 100;
        }
        else
        {
            return 0;
        }
    }
}