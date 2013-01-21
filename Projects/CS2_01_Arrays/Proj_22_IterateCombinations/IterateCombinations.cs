using System;
using System.Text;
using System.IO;

class IterateCombinations
{
    /* Write a program that reads two numbers N and K and generates
    * all the combinations of K distinct elements from the 
    * set [1..N].
    */
    static void Main()
    {
        Console.Write("n (1 <= n <= 31) = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k (1 <= k <= {0}) = ", n);
        int k = int.Parse(Console.ReadLine());
        if (1 <= n && 1 <= k && k <= n)
        {
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
        int count = 0;
        for (int i = 0; i < CodeOfAll(args[0]); i++)
        {
            if (CountElements(i) == args[1])
            {
                Console.WriteLine(DecodeCombination(i));
                count++;
            }
        }
        Console.WriteLine("Total: {0} combinations", count);
        return count;
    }
    public static int CodeOfAll(int numberOfElements)
    {
        return ~(-1 << numberOfElements);
    }
    public static int CountElements(int n)
    {
        int count = 0;
        for (int i = 0; i < 31; i++)
        {
            if ((n & 1) == 1)
            {
                count++;
            }
            n >>= 1;
        }
        return count;
    }
    public static string DecodeCombination(int n)
    {
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < 31; i++)
        {
            if ((n & 1) == 1)
            {
                str.Append(i + 1).Append(' ');
            }
            n >>= 1;
        }
        return str.ToString().TrimEnd(' ');
    }
}
