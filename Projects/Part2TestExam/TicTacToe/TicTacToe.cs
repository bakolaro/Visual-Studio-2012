using System;
using System.Collections.Generic;

class TicTacToe
{
    static void Main()
    {
        string[] input = new string[3];
        for (int i = 0; i < 3; i++ )
        {
            input[i] = Console.ReadLine();
        }

        int[] x = new int[3];
        int[] o = new int[3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (input[i][j] == 'X')
                {
                    x[i] |= (1 << j);
                }
                else if (input[i][j] == 'O')
                {
                    o[i] |= (1 << j);
                }
                else
                {
                    // do nothing
                }
            }
        }

        int vector = (o[2] << 15) | (o[1] << 12) | (o[0] << 9) | 
            (x[2] << 6) | (x[1] << 3) | x[0];

        int xCounter = 0, oCounter = 0;
        for (int i = 0; i <= vector; i++)
        {
            int c = CountOne(vector, i);
            if (c > 0)
            {
                xCounter++;
            }
            else if (c < 0)
            {
                oCounter++;
            }
        }

        Console.WriteLine(xCounter);
        Console.WriteLine(oCounter);

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (((x[i] >> j) & 1) == 1)
                {
                    Console.Write('X');
                }
                else if (((o[i] >> j) & 1) == 1)
                {
                    Console.Write('O');
                }
                else
                {
                    Console.Write('-');
                }
            }
            Console.WriteLine();
        }
    }
    public static bool ValidNumberOfBits(int v)
    {
        int counter = 0;
        for (int i = 0; i < 9; i++)
        {
            if (((v >> i) & 1) == 1)
            {
                counter++;
            }
        }
        for (int i = 9; i < 18; i++)
        {
            if (((v >> i) & 1) == 1)
            {
                counter--;
            }
        }
        return (counter == 0) || (counter == 1);
    }

    public static int CountOne(int startVector, int endVector)
    {
        bool b = // endVector contains startVector
            ((startVector & endVector) == startVector)
            // both parts do not overlap
            && ((endVector & 511 & (endVector >> 9)) == 0)
            // both parts have equal number of bits or the rightmost part has one more    
            && ValidNumberOfBits(endVector);
        if(b)
        {
            int xLines = 0;
            // represents exactly one row of 1-s
            if ((endVector & 7) == 7) xLines++;
            if ((endVector & (7 << 3)) == (7 << 3)) xLines++; if (xLines > 1) return 0;
            if ((endVector & (7 << 6)) == (7 << 6)) xLines++; if (xLines > 1) return 0;
            // or one diagonal
            if ((endVector & (1 | (1 << 4) | (1 << 8))) == (1 | (1 << 4) | (1 << 8))) xLines++; if (xLines > 1) return 0;
            if ((endVector & ((1 << 2) | (1 << 4) | (1 << 6))) == ((1 << 2) | (1 << 4) | (1 << 6))) xLines++; if (xLines > 1) return 0;
            // or one column
            if ((endVector & (1 | (1 << 3) | (1 << 6))) == (1 | (1 << 3) | (1 << 6))) xLines++; if (xLines > 1) return 0;
            if ((endVector & ((1 << 1) | (1 << 4) | (1 << 7))) == ((1 << 1) | (1 << 4) | (1 << 7))) xLines++; if (xLines > 1) return 0;
            if ((endVector & ((1 << 2) | (1 << 5) | (1 << 8))) == ((1 << 2) | (1 << 5) | (1 << 8))) xLines++; if (xLines > 1) return 0;

            int oLines = 0;
            if ((endVector & (7 << 9)) == (7 << 9)) oLines++; if (xLines + oLines > 1) return 0;
            if ((endVector & (7 << 12)) == (7 << 12)) oLines++; if (xLines + oLines > 1) return 0;
            if ((endVector & (7 << 15)) == (7 << 15)) oLines++; if (xLines + oLines > 1) return 0;
            if ((endVector & ((1 << 9) | (1 << 13) | (1 << 17))) == ((1 << 9) | (1 << 13) | (1 << 17))) oLines++; if (xLines + oLines > 1) return 0;
            if ((endVector & ((1 << 11) | (1 << 13) | (1 << 15))) == ((1 << 11) | (1 << 13) | (1 << 15))) oLines++; if (xLines + oLines > 1) return 0;
            if ((endVector & ((1 << 9) | (1 << 12) | (1 << 15))) == ((1 << 9) | (1 << 12) | (1 << 15))) oLines++; if (xLines + oLines > 1) return 0;
            if ((endVector & ((1 << 10) | (1 << 13) | (1 << 16))) == ((1 << 10) | (1 << 13) | (1 << 16))) oLines++; if (xLines + oLines > 1) return 0;
            if ((endVector & ((1 << 11) | (1 << 14) | (1 << 17))) == ((1 << 11) | (1 << 14) | (1 << 17))) oLines++; if (xLines + oLines > 1) return 0;
            if (xLines > 0) return 1;
            if (oLines > 0) return -1;
            return 0;
        }
        else
        {
            return 0;
        }
    }
}
