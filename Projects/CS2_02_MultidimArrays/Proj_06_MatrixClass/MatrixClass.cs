using System;
using System.Text;
using System.IO;

public class TestMatrix
{
    /* Write a class Matrix, to holds a matrix of integers. Overload
     * the operators for adding, subtracting and multiplying of matrices,
     * indexer for accessing the matrix content and ToString().
     */
    public static void Main()
    {
        Matrix a = new Matrix("MatrixIntA.in");
        Matrix b = new Matrix("MatrixIntB.in");
        Matrix c = new Matrix("MatrixIntC.in");
        Console.WriteLine(@"        A
=================");
        Console.WriteLine(a);
        Console.WriteLine(@"        B
=================");
        Console.WriteLine(b);
        Console.WriteLine(@"        C
=================");
        Console.WriteLine(c);
        Console.WriteLine(@"      A * B
=================");
        Console.WriteLine(a * b);
        Console.WriteLine(@"      B + C
=================");
        Console.WriteLine(b + c);
        Console.WriteLine(@"      B - C
=================");
        Console.WriteLine(b - c);
        try
        {
            Console.WriteLine(@"      B * C
=================");
            Console.WriteLine(b * c);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }
}
public class Matrix
{
    private int[,] Cells;
    public Matrix(int rows, int columns)
    {
        Cells = new int[rows, columns];
    }
    public Matrix(string file)
    {
        string[] input = File.ReadAllLines(file);
        string[][] cells = new string[input.Length][];
        for (int i = 0; i < input.Length; i++)
        {
            cells[i] = input[i].Split();
        }
        Cells = new int[cells.Length, cells[0].Length];
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                this[i, j] = int.Parse(cells[i][j]);
            }
        }
    }
    public int Rows
    {
        get
        {
            return Cells.GetLength(0);
        }
    }
    public int Columns
    {
        get
        {
            return Cells.GetLength(1);
        }
    }
    public int this[int row, int column]
    {
        get
        {
            return Cells[row, column];
        }
        set
        {
            Cells[row, column] = value;
        }
    }
    public static Matrix operator *(Matrix a, Matrix b)
    {
        if (a.Columns != b.Rows)
        {
            throw new ArgumentException(string.Format(@"The number of columns in the first matrix ({0}) should match 
the number of rows in the second matrix ({1}).", a.Columns, b.Rows));
        }
        Matrix product = new Matrix(a.Rows, b.Columns);
        for (int i = 0; i < a.Rows; i++)
        {
            for (int j = 0; j < b.Columns; j++)
            {
                for (int k = 0; k < a.Columns; k++)
                {
                    product[i, j] += a[i, k] * b[k, j];
                }
            }
        }
        return product;
    }
    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.Columns != b.Columns || a.Rows != b.Rows)
        {
            throw new ArgumentException(string.Format(@"The number of rows and columns in the first matrix ({0} x {1}) should match 
the number of rows and columns in the second matrix ({2} x {3}).", a.Rows, a.Columns, b.Rows, b.Columns));
        }
        Matrix sum = new Matrix(a.Rows, a.Columns);
        for (int i = 0; i < a.Rows; i++)
        {
            for (int j = 0; j < a.Columns; j++)
            {
                sum[i, j] = a[i, j] + b[i, j];
            }
        }
        return sum;
    }
    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.Columns != b.Columns || a.Rows != b.Rows)
        {
            throw new ArgumentException(string.Format(@"The number of rows and columns in the first matrix ({0} x {1}) should match 
the number of rows and columns in the second matrix ({2} x {3}).", a.Rows, a.Columns, b.Rows, b.Columns));
        }
        Matrix difference = new Matrix(a.Rows, a.Columns);
        for (int i = 0; i < a.Rows; i++)
        {
            for (int j = 0; j < a.Columns; j++)
            {
                difference[i, j] = a[i, j] - b[i, j];
            }
        }
        return difference;
    }
    override public string ToString()
    {
        int maxWidth = 0;
        for (int i = 0; i < this.Rows; i++)
        {
            for (int j = 0; j < this.Columns; j++)
            {
                int width = this[i, j].ToString().Length;
                if (width > maxWidth)
                {
                    maxWidth = width;
                }
            }
        }
        maxWidth++;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < this.Rows; i++)
        {
            for (int j = 0; j < this.Columns; j++)
            {
                sb.AppendFormat("{0, " + maxWidth + "}", this[i, j]);
            }
            sb.AppendLine();
        }
        return sb.ToString();
    }
}
