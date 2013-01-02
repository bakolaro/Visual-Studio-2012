using System;

class TelerikLogo
{
    static void Main()
    {
        int X = int.Parse(Console.ReadLine()); // odd number
        int Z = X / 2 + 1;
        int d = 3 * X - 2;
        char[,] logo = new char[d, d];

        for (int i = 0; i < d; i++)
        {
            for (int j = 0; j < d; j++)
            {
                if ((j == X / 2 + i && i <= 2 * X - 2)
                    || (j == 3 * X - 3 - X / 2 - i && i <= 2 * X - 2)
                    || ((j == -2 * X + X / 2 + i + 2) && (i > 2 * X - 2))
                    || ((j == 5 * X - 5 - X / 2 - i) && (i > 2 * X - 2))
                    || (j == X / 2 + i + 2 * X - 2)
                    || (j == 3 * X - 3 - X / 2 - i - 2 * X + 2)
                    )
                {
                    logo[i, j] = '*';
                }
                else
                {
                    logo[i, j] = '.';
                }
            }
        }

        for (int i = 0; i < d; i++)
        {
            for (int j = 0; j < d; j++)
            {
                Console.Write(logo[i, j]);
            }
            Console.WriteLine();
        }
    }
}