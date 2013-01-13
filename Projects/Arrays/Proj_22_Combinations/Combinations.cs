using System;

class Combinations
{
    /* Write a program that reads two numbers N and K and generates
     * all the combinations of K distinct elements from the 
     * set [1..N].
     */
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        int[,] c = CombinationsArray(n, k);
        // Print combinations on screen
        PrintMatrix(c);
    }
    public static int Factorial(int n)
    {
        int f = 1;
        for (int i = 2; i <= n; i++)
        {
            f *= i;
        }
        return f;
    }
    public static int VariationsCount(int n, int k)
    {
        int v = 1;
        for (int i = n - k + 1; i <= n; i++)
        {
            v *= i;
        }
        return v;
    }
    public static int CombinationsCount(int n, int k)
    {
        return VariationsCount(n, k) / Factorial(k);
    }
    public static int[,] CombinationsArray(int n, int k)
    {
        if (n == k)
        {
            int[,] table = new int[1, n];
            for (int j = 0; j < n; j++)
            {
                table[0, j] = j + 1;
            }
            return table;
        }
        else if (k == 1)
        {
            int[,] table = new int[n, 1];
            for (int i = 0; i < n; i++)
            {
                table[i, 0] = i + 1;
            }
            return table;
        }
        else
        {
            int[,] c0 = CombinationsArray(n - 1, k - 1);
            int[,] c1 = CombinationsArray(n - 1, k);
            int[,] table = new int[c0.GetLength(0) + c1.GetLength(0), k];
            for (int i = 0; i < c0.GetLength(0); i++)
            {
                table[i, 0] = n;
                for (int j = 0; j < c0.GetLength(1); j++)
                {
                    table[i, j + 1] = c0[i, j];
                }
            }
            for (int i = 0; i < c1.GetLength(0); i++)
            {
                for (int j = 0; j < c1.GetLength(1); j++)
                {
                    table[i + c0.GetLength(0), j] = c1[i, j];
                }
            }
            return table;
        }
    }
    public static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                Console.Write("{0,3}", matrix[row, column]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("--------");
    }
}
