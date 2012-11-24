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

        Line longestByRows = LongestLine(a);
        Line longestByColumns = LongestLine(TransposeBits8x8(a));
        if (longestByRows.length > longestByColumns.length)
        {
            Console.WriteLine(longestByRows.length);
            Console.WriteLine(longestByRows.count);
        }
        else if (longestByRows.length < longestByColumns.length)
        {
            Console.WriteLine(longestByColumns.length);
            Console.WriteLine(longestByColumns.count);
        }
        else
        {
            Console.WriteLine(longestByRows.length);
            Console.WriteLine(longestByRows.count + longestByColumns.count);
        }
    }

    struct Line
    {
        public int length, count;

        public Line(int lineLength, int lineCount)
        {
            length = lineLength;
            count = lineCount;
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
                if (length > g.length)
                {
                    g.length = length;
                    g.count = 1;
                }
                else if (length == g.length)
                {
                    g.count++;
                }
                length = 0;
            }
            x >>= 1;
        }
        while (x > 0);
        if (length > g.length)
        {
            g.length = length;
            g.count = 1;
        }
        else if (length == g.length)
        {
            g.count++;
        }

        return g;
    }

    static Line LongestLine(int[] a)
    {
        Line g = LongestLine(a[0]);
        for (int i = 1; i < a.Length; i++)
        {
            Line h = LongestLine(a[i]);
            if (h.length > g.length)
            {
                g.length = h.length;
                g.count = h.count;
            }
            else if (h.length == g.length)
            {
                g.count += h.count;
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
