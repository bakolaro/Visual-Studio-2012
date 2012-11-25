using System;

class ShipDamage
{
    static void Main()
    {
        // Input data
        long sx1 = long.Parse(Console.ReadLine());
        long sy1 = long.Parse(Console.ReadLine());
        long sx2 = long.Parse(Console.ReadLine());
        long sy2 = long.Parse(Console.ReadLine());
        long h = long.Parse(Console.ReadLine());
        long c1x = long.Parse(Console.ReadLine());
        long c1y = long.Parse(Console.ReadLine());
        long c2x = long.Parse(Console.ReadLine());
        long c2y = long.Parse(Console.ReadLine());
        long c3x = long.Parse(Console.ReadLine());
        long c3y = long.Parse(Console.ReadLine());

        // Calculate
        Ship s = new Ship(new Polong(sx1, sy1), new Polong(sx2, sy2));

        long p1x = c1x;
        long p1y = h + (h - c1y);
        long damage1 = ProjectileDamage(s, new Polong(p1x, p1y));

        long p2x = c2x;
        long p2y = h + (h - c2y);
        long damage2 = ProjectileDamage(s, new Polong(p2x, p2y));

        long p3x = c3x;
        long p3y = h + (h - c3y);
        long damage3 = ProjectileDamage(s, new Polong(p3x, p3y));

        long damage = damage1 + damage2 + damage3;
        // Ouptut data
        Console.WriteLine(damage + "%");
    }

    struct Ship
    {
        public long X1, Y1, X2, Y2;

        public Ship(Polong c1, Polong c2)
        {
            X1 = c1.X;
            Y1 = c1.Y;
            X2 = c2.X;
            Y2 = c2.Y;
        }
    }

    struct Polong
    {
        public long X, Y;

        public Polong(long px, long py)
        {
            X = px;
            Y = py;
        }
    }

    static long ProjectileDamage(Ship s, Polong projectile)
    {
        if ((s.X1 == projectile.X || s.X2 == projectile.X) &&
            (s.Y1 == projectile.Y || s.Y2 == projectile.Y))
        {
            return 25;
        }
        else if ((s.X1 == projectile.X || s.X2 == projectile.X) &&
            ((s.Y1 - projectile.Y) * (s.Y2 - projectile.Y) < 0) ||
            (s.Y1 == projectile.Y || s.Y2 == projectile.Y) &&
            ((s.X1 - projectile.X) * (s.X2 - projectile.X) < 0))
        {
            return 50;
        }
        else if (((s.Y1 - projectile.Y) * (s.Y2 - projectile.Y) < 0) &&
            ((s.X1 - projectile.X) * (s.X2 - projectile.X) < 0))
        {
            return 100;
        }
        else
        {
            return 0;
        }
    }
}