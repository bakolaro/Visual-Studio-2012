using System;
using System.IO;

class Permutations
{
    /* Write a program that reads a number N and generates
     * and prints all the permutations of the numbers [1 … N].
     */
    static void Main()
    {
        Console.Write("n (1 <= n <= 12) = ");
        int n = int.Parse(Console.ReadLine());
        if (1 <= n && n <= 12)
        {
            int count = RedirectOutput(string.Format("Permutations-of-{0}.txt", n),
                ListPermutations, n);
            Console.WriteLine("List of {1} permutations was exported to:\r\n" +
                "bin/Debug/Permutations-{0}.txt", n, count);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
    public delegate int Calc(int arg);
    public static int RedirectOutput(string file, Calc c, int arg)
    {
        // Redirect output to file:
        // 1. Get the original IO streams
        TextWriter standardWriter = Console.Out;
        // 2. Create new output stream
        StreamWriter writer = new StreamWriter(file);
        Console.SetOut(writer);
        // 3. Write to file
        int outputLines = c(arg);
        writer.Close();
        Console.SetOut(standardWriter);
        // Get back to standard output stream
        return outputLines;
    }
    public static int ListPermutations(int n)
    {
        if (n > 0 && n < 13)
        {
            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                count *= i;
            }

            Console.WriteLine ("Numbers from 1 to {0} have {1} permutations.", n, count);

            int[] a = new int[n];
            for (int i = 0; i < count; i++)
            {
                bool[] integers = new bool[n];
                int p = count, q = n;
                for (int j = 0; j < n; j++)
                {
                    p /= q--;
                    int cnt = (i / p) % (n - j) + 1;

                    int k = 0;
                    while (k < n && cnt > 0)
                    {
                        if (!integers[k])
                        {
                            cnt--;
                        }
                        k++;
                    }
                    integers[k - 1] = true;
                    a[j] = k;

                    Console.Write ("{0, 4}", a[j]);
                }
                Console.WriteLine();
            }
            return count;
        }
        else
        {
            Console.WriteLine ("Invalid data! Let n > 0 and n < 13.");
            return 0;
        }
    }
}
