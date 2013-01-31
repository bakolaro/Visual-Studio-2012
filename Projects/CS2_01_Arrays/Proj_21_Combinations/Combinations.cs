using System;
using System.IO;

class Combinations
{
    /* Write a program that reads two numbers N and K and generates
     * all the combinations of K distinct elements from the 
     * set [1..N].
     */
    static void Main()
    {
        Console.Write("n (1 <= n <= 16) = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k (1 <= k <= {0}) = ", n);
        int k = int.Parse(Console.ReadLine());
        if (1 <= k && k <= n && n <= 16)
        {
            int m = CombinationsCount(n, k);
            Console.WriteLine(m);
            int count = RedirectOutput(string.Format("Combinations-{1}-of-{0}.txt", n, k),
                ListCombinations, n, k);
            Console.WriteLine("List of {2} combinations was exported to:\r\n" +
                "bin/Debug/Combinations-{1}-of-{0}.txt", n, k, count);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
    public delegate int Calc(int[] args);
    public static int RedirectOutput(string file, Calc c, params int[] args)
    {
        // Redirect output to file:
        // 1. Get the original IO streams
        TextWriter standardWriter = Console.Out;
        // 2. Create new output stream
        StreamWriter writer = new StreamWriter(file);
        Console.SetOut(writer);
        // 3. Write to file
        int outputLines = c(args);
        writer.Close();
        Console.SetOut(standardWriter);
        // Get back to standard output stream
        return outputLines;
    }
    public static int ListCombinations(int[] args)
    {
        int[,] matrix = CombinationsArray(args[0], args[1]);
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1) - 1; column++)
            {
                Console.Write("{0} ", matrix[row, column]);
            }
            Console.WriteLine("{0}", matrix[row, matrix.GetLength(1) - 1]);
        }
        int count = matrix.GetLength(0);
        Console.WriteLine("Total: {0} combinations", count);
        return count;
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
    public static int CombinationsCount(int n, int k)
    {
        if (k > n || k < 1)
        {
            return 0;
        }
        else
        {
            int less, more;
            if (k < n - k)
            {
                less = k;
                more = n - k;
            }
            else
            {
                less = n - k;
                more = k;
            }
            checked
            {
                int denominator = 1;
                for (int i = 2; i <= less; i++)
                {
                    denominator *= i;
                }
                int numerator = 1;
                for (int i = more + 1; i <= n; i++)
                {
                    numerator *= i;
                }
                return numerator / denominator;
            }
        }
    }
}
