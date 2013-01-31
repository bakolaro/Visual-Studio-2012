using System;
using System.IO;

class Variations
{
    /* Write a program that reads two numbers N and K and
     * generates all the variations of K elements from
     * the set [1..N].
     */
    static void Main()
    {
        Console.Write("n (1 <= n <= 13) = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k (1 <= k <= {0}) = ", n);
        int k = int.Parse(Console.ReadLine());
        if (1 <= k && k <= n && n <= 13)
        {
            int count = RedirectOutput(string.Format("Variations-{1}-of-{0}.txt", n, k),
                ListVariations, n, k);
            Console.WriteLine("List of {2} variations was exported to:\r\n" +
                "bin/Debug/Variations-{1}-of-{0}.txt", n, k, count);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
    public delegate int Calc(int arg1, int arg2);
    public static int RedirectOutput(string file, Calc c, int arg1, int arg2)
    {
        // Redirect output to file:
        // 1. Get the original IO streams
        TextWriter standardWriter = Console.Out;
        // 2. Create new output stream
        StreamWriter writer = new StreamWriter(file);
        Console.SetOut(writer);
        // 3. Write to file
        int outputLines = c(arg1, arg2);
        writer.Close();
        Console.SetOut(standardWriter);
        // Get back to standard output stream
        return outputLines;
    }
    public static int ListVariations(int n, int k)
    {
        if (1 <= k && k <= n)
        {
            int variations = 1;
            checked
            {
                for (int i = n; i > n - k; i--)
                {
                    variations *= i;
                }
            }
            Console.WriteLine("Variations = " + variations);
            for (int i = 0; i < variations; i++)
            {
                // isNotAvailable is false i.e. isAvailable
                bool[] isNotAvailable = new bool[n];

                int numberOfAvailElems = n;
                int variationsOfAvailElems = variations;

                for (int j = 0; j < k; j++)
                {
                    numberOfAvailElems--;

                    // size of lots (number of consequtive rows with
                    // the same elements in columns from 0 to j),
                    // i.e. the number of variations of the available
                    // elements
                    if (numberOfAvailElems + 1 > 0)
                    {
                        variationsOfAvailElems /= (numberOfAvailElems + 1);
                    }
                    else
                    {
                        variationsOfAvailElems = 1;
                    }

                    // lot identifier, i.e. the number of full lots
                    // which lie before the current row
                    int lotId = i / variationsOfAvailElems;

                    int indexInListOfAvailElems =
                        lotId % (numberOfAvailElems + 1);

                    int x = 0;
                    int counterOfAvailElems =
                        indexInListOfAvailElems + 1;
                    while (x < n && counterOfAvailElems > 0)
                    {
                        if (!isNotAvailable[x])
                        {
                            counterOfAvailElems--;
                        }
                        x++;
                    }
                    isNotAvailable[x - 1] = true;
                    Console.Write ("{0,3}", x);
                }
                Console.WriteLine ();
            }
            return variations;
        }
        else
        {
            Console.WriteLine ("Invalid data! Let 1 <= k <= n.");
            return 0;
        }
    }
}