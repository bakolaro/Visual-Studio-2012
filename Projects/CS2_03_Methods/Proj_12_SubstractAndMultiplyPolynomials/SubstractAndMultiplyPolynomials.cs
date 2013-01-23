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
            IOArrays.WriteVector<int>(SubstractPolynomialCoefficients(a[i]));
            Console.Write("Multiply polynomials: ");
            IOArrays.WriteVector<int>(MultiplyPolynomials(a[i]));

            Console.WriteLine();
        }
    }
    public static int[] AddPolynomialCoefficients(int[,] a)
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
    public static int[] SubstractPolynomialCoefficients(int[,] a)
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
    public static int[] MultiplyFirstTwoPolynomials(int[,] a)
    {
        int m = a.GetLength(0);
        int n = a.GetLength(1);
        int[] result = new int[n + n - 1];
        for (int j = 0; j < n; j++)
        {
            for (int i = 0; i < n; i++)
            {
                result[i + j] += a[0, j] * a[1, i];
            }
        }
        return result;
    }
    public static int[] MultiplyPolynomials(int[,] a)
    {
        // to do: find an error
        int m = a.GetLength(0);
        int n = a.GetLength(1);
        int[] b = new int[m * (n - 1) + 1];
        b[0] = 1;
        int[] c = new int[m * (n - 1) + 1];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    c[j + k] += b[j] * a[i, k];
                }
            }
            b = c;
            c = new int[m * (n - 1) + 1];
        }
        return b;
    }
}