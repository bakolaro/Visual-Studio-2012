using System;

// Add reference to IOArrays (a class library in this solution)

public class SubstractAndMultiplyPolynomials
{
    /* Write a method that adds two polynomials. Represent them as 
     * arrays of their coefficients.
     */
    public static void Main()
    {
        IOArrays.WriteInputFormatSpecification();
        string input = "SubstractAndMultiplyPolynomials.in";
        Console.WriteLine(@"Input integer vectors from file (""bin/.../{0}"")", input);

        int[][,] a = IOArrays.ReadIntMatricesFromFile(input, false);
        for (int i = 0; i < a.Length; i++)
        {
            IOArrays.WriteMatrix(a[i]);
            Console.Write("Substract polynomials from first one: ");
            IOArrays.WriteVector<int>(SubstractPolynomials(a[i]));
            Console.Write("Multiply polynomials: ");
            IOArrays.WriteVector<int>(MultiplyPolynomials(a[i]));

            Console.WriteLine();
        }
    }
    public static int[] AddPolynomials(int[,] a)
    {
        int m = a.GetLength(0);
        int n = a.GetLength(1);
        int[] result = new int[n];
        
        for (int j = 0; j < n; j++)
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum += a[i, j];
            }
            result[j] = sum;
        }

        return result;
    }
    public static int[] SubstractPolynomials(int[,] a)
    {
        int m = a.GetLength(0);
        int n = a.GetLength(1);
        int[] result = new int[n];
        for (int j = 0; j < n; j++)
        {
            int sum = a[0, j];
            for (int i = 1; i < m; i++)
            {
                sum -= a[i, j];
            }
            result[j] = sum;
        }
        return result;
    }
    public static int[] MultiplyPolynomials(int[,] a)
    {
        int m = a.GetLength(0);
        int n = a.GetLength(1);
        int maxPower = m * (n - 1) + 1;
        int[] b = new int[maxPower];
        b[0] = 1;
        for (int i = 0; i < m; i++)
        {
            int[] c = new int[maxPower];
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < maxPower - j; k++)
                {
                    c[k + j] += b[k] * a[i, j];
                }
            }
            b = c;
        }
        return TrimLeadingZeros(b);
    }
    public static int[] TrimLeadingZeros(int[] b)
    {
        int nonzero = 0;
        for (int i = 0; i < b.Length; i++)
        {
            if (b[i] != 0)
            {
                break;
            }
            nonzero++;
        }
        if (nonzero > -1)
        {
            int[] d = new int[b.Length - nonzero];
            for (int i = nonzero; i < b.Length; i++)
            {
                d[i - nonzero] = b[i];
            }
            b = d;
        }
        return b;
    }
}