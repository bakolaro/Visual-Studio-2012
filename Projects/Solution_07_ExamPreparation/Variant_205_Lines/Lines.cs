using System;

class Lines
{
    static void Main()
    {
        int[] a = new int[8];
        for (int i = 0; i < 8; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        int[] b = TransposeBits8x8(a);

        Line longestByRows = LongestLine(a);
        Line longestByColumns = LongestLine(b);
        if (longestByRows.Length > longestByColumns.Length)
        {
            Console.WriteLine(longestByRows.Length);
            Console.WriteLine(longestByRows.Count);
        }
        else if (longestByRows.Length < longestByColumns.Length)
        {
            Console.WriteLine(longestByColumns.Length);
            Console.WriteLine(longestByColumns.Count);
        }
        else if (longestByRows.Length > 1)
        {
            Console.WriteLine(longestByRows.Length);
            Console.WriteLine(longestByRows.Count + longestByColumns.Count);
        }
        else
        {
            Console.WriteLine(longestByRows.Length);
            Console.WriteLine(longestByRows.Count);
        }
    }

    struct Line
    {
        public int Length, Count;

        public Line(int lineLength, int lineCount)
        {
            Length = lineLength;
            Count = lineCount;
        }
    }

    static Line LongestLine(int n)
    {
        int x = n;
        int length = 0;
        Line g = new Line(0, 0);
        do
        {
            if ((x & 1) == 1)
            {
                length++;
            }
            else
            {
                if (length > g.Length)
                {
                    g.Length = length;
                    g.Count = 1;
                }
                else if (length == g.Length)
                {
                    g.Count++;
                }
                length = 0;
            }
            x >>= 1;
        }
        while (x > 0);
        if (length > g.Length)
        {
            g.Length = length;
            g.Count = 1;
        }
        else if (length == g.Length)
        {
            g.Count++;
        }

        return g;
    }

    static Line LongestLine(int[] a)
    {
        Line g = LongestLine(a[0]);
        for (int i = 1; i < a.Length; i++)
        {
            Line h = LongestLine(a[i]);
            if (h.Length > g.Length)
            {
                g.Length = h.Length;
                g.Count = h.Count;
            }
            else if (h.Length == g.Length)
            {
                g.Count += h.Count;
            }
        }
        return g;
    }

    static int[] TransposeBits8x8(int[] a)
    {
        int[] b = new int[8];

        for (int rowIndex = 0; rowIndex < 8; rowIndex++)
        {
            for (int columnIndex = 0; columnIndex < 8; columnIndex++)
			{
                b[columnIndex] |= (((a[rowIndex] >> columnIndex) & 1) << rowIndex);
			}
        }
        return b;
    }
}
