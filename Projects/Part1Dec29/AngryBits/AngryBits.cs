using System;

class AngryBits
{
    static void Main()
    {
        int[] n = new int[8];
        for (int i = 0; i < 8; i++)
        {
            n[i] = int.Parse(Console.ReadLine());
        }
        int total = TotalPoints(n);
        int sum = 0;
        for (int i = 0; i < 8; i++)
        {
            sum += n[i];
        }
        sum &= 255;
        if (sum == 0)
        {
            Console.WriteLine("{0} Yes", total);
        }
        else
        {
            Console.WriteLine("{0} No", total);
        }
    }

    public static int TotalPoints(int[] n)
    {
        int total = 0;
        for (int y = 8; y < 16; y++)
        {
            for (int x = 0; x < 8; x++)
            {
                if (((n[x] >> y) & 1) == 1)
                {
                    total += HitPoints(n, x, y);
                }
            }
        }
        return total;
    }

    public static int HitPoints(int[] n, int x, int y)
    {
        int moves = 0;
        int dx;
        if (x == 0)
        {
            dx = 1;
        }
        else
        {
            dx = -1;
        }
        while(x + dx <= 7 && y > 0)
        {
            if (x == 0)
            {
                dx = 1;
            }
            x += dx;
            y--;
            moves++;

            int destroyed = DestroyedPigs(n, x, y);
            // Console.WriteLine("{0,4}{1,4}{2,4}{3,4}", x, y, moves, destroyed);
            if (destroyed > 0)
            {
                return moves * destroyed;
            }
        }
        return 0;
    }

    public static int DestroyedPigs(int[] n, int x, int y)
    {
        int killed = 0;
        if ((y < 8) && ((n[x] >> y) & 1) == 1)
        {
            n[x] &= ~(1 << y);
            killed++;

            if (x > 0)
            {
                if((y > 0) && ((n[x - 1] >> y - 1) & 1) == 1)
                {
                    n[x - 1] &= ~(1 << y - 1);
                    killed++;
                }
                if (((n[x - 1] >> y) & 1) == 1)
                {
                    n[x - 1] &= ~(1 << y);
                    killed++;
                }
                if ((y < 7) && ((n[x - 1] >> y + 1) & 1) == 1)
                {
                    n[x - 1] &= ~(1 << y + 1); 
                    killed++;
                }
            }
            if (x < 7)
            {
                if ((y > 0) && ((n[x + 1] >> y - 1) & 1) == 1)
                {
                    n[x + 1] &= ~(1 << y - 1); 
                    killed++;
                }
                if (((n[x + 1] >> y) & 1) == 1)
                {
                    n[x + 1] &= ~(1 << y); 
                    killed++;
                }
                if ((y < 7) && ((n[x + 1] >> y + 1) & 1) == 1)
                {
                    n[x + 1] &= ~(1 << y + 1); 
                    killed++;
                }
            }
            if ((y > 0) && ((n[x] >> y - 1) & 1) == 1)
            {
                n[x] &= ~(1 << y - 1); 
                killed++;
            }
            if ((y < 7) && ((n[x] >> y + 1) & 1) == 1)
            {
                n[x] &= ~(1 << y + 1); 
                killed++;
            }
        }
        return killed;
    }
}
