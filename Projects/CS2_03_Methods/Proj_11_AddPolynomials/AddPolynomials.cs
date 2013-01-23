using System;

// Add reference to IOArrays (a class library in this solution)

public class AddPolynomials
{
    /* Write a method that adds two polynomials. Represent them as 
     * arrays of their coefficients.
     */
    public static void Main()
    {
        IOArrays.WriteInputFormatSpecification();
        string input = "AddPlynomials.in";
        Console.WriteLine(@"Input integer vectors from file (""bin/.../{0}"")", input);

        int[][,] a = IOArrays.ReadIntMatricesFromFile(input, false);
        for (int i = 0; i < a.Length; i++)
        {
            IOArrays.WriteMatrix(a[i]);
            Console.WriteLine();
            IOArrays.WriteVector<int>(AddPolynomialCoefficients(a[i]));
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
}