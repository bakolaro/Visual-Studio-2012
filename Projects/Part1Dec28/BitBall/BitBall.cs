using System;

class BitBall
{
    static void Main()
    {
        int[] n = new int[16];
        for (int i = 0; i < 16; i++)
        {
            n[i] = int.Parse(Console.ReadLine());
        }
        // play ground
        int[] playGround = new int[8];
        // collision detection - players receive red cards
        for (int j = 0; j < 8; j++)
        {
            for (int i = 0; i < 8; i++)
            {
                if ((((n[i] >> j) & 1) == 1) && (((n[i + 8] >> j) & 1) == 1))
                {
                    n[i] &= ~(1 << j);
                    n[i + 8] &= ~(1 << j);
                }
            }
        }
        // players score
        int topScore = 0, bottomScore = 0;
        for (int j = 0; j < 8; j++)
        {
            bool topTeamGetsTheBall = false, bottomTeamGetsTheBall = false;
            for (int i = 0; i < 8; i++)
            {
                if (((n[i] >> j) & 1) == 1)
                {
                    topTeamGetsTheBall = true;
                }
                if (((n[i + 8] >> j) & 1) == 1)
                {
                    topTeamGetsTheBall = false;
                }

                if (((n[15 - i] >> j) & 1) == 1)
                {
                    bottomTeamGetsTheBall = true;
                }
                if (((n[7 - i] >> j) & 1) == 1)
                {
                    bottomTeamGetsTheBall = false;
                }
            }
            if (topTeamGetsTheBall)
            {
                topScore++;
            }
            if (bottomTeamGetsTheBall)
            {
                bottomScore++;
            }
        }
        Console.WriteLine("{0}:{1}", topScore, bottomScore);
    }
}

