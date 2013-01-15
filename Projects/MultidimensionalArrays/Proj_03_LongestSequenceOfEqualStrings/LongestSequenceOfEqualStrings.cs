using System;

namespace MultidimensionalArrays
{
    class LongestSequenceOfEqualStrings
    {
        public struct Sequence
        {
            public int row, column, rows, columns;
            public string @string;
        }

        static void Main()
        {
            Console.Write("m (rows) = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("n (columns) = ");
            int n = int.Parse(Console.ReadLine());

            string[,] a = ArrayMethods.ReadStringMatrix(m, n);

            Sequence maxGlobal = new Sequence();
            for (int row = 0; row < m; row++)
            {
                Sequence maxLocal = new Sequence();
                Sequence s = new Sequence();
                for (int column = 0; column < n; column++)
                {
                    if (column == 0)
                    {
                        s.row = row;
                        s.column = column;
                        s.rows = 1;
                        s.columns = 1;
                        s.@string = a[row, column];
                        maxLocal = s;
                    }
                    else
                    {
                        if (a[row, column] == a[row, column - 1])
                        {
                            s.columns++;
                            if (s.columns > maxLocal.columns)
                            {
                                maxLocal = s;
                            }
                        }
                        else
                        {
                            s.row = row;
                            s.column = column;
                            s.rows = 1;
                            s.columns = 1;
                            s.@string = a[row, column];
                            maxLocal = s;
                        }
                    }
                }
                if (Math.Max(maxLocal.rows, maxLocal.columns) > Math.Max(maxGlobal.rows, maxGlobal.columns))
                {
                    maxGlobal = maxLocal;
                }
            }
            for (int column = 0; column < n; column++) 
            {
                Sequence maxLocal = new Sequence();
                Sequence s = new Sequence();
                for (int row = 0; row < m; row++)
                {
                    if (row == 0)
                    {
                        s.row = row;
                        s.column = column;
                        s.rows = 1;
                        s.columns = 1;
                        s.@string = a[row, column];
                        maxLocal = s;
                    }
                    else
                    {
                        if (a[row, column] == a[row - 1, column])
                        {
                            s.rows++;
                            if (s.rows > maxLocal.rows)
                            {
                                maxLocal = s;
                            }
                        }
                        else
                        {
                            s.row = row;
                            s.column = column;
                            s.rows = 1;
                            s.columns = 1;
                            s.@string = a[row, column];
                            maxLocal = s;
                        }
                    }
                }
                if (Math.Max(maxLocal.rows, maxLocal.columns) > Math.Max(maxGlobal.rows, maxGlobal.columns))
                {
                    maxGlobal = maxLocal;
                }
            }
            for (int diagonal = 1 - m; diagonal < n; diagonal++)
            {
 
            }
        }
    }
}
