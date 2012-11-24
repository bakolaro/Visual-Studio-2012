using System;

class FirTree
{
    static void Main()
    {
        // Input data
        int n = int.Parse(Console.ReadLine());

        // Calculate and output data
        string sky, tree;
        for (int i = n - 2, j = 1; i >= 0; i--, j += 2)
        {
            sky = new string('.', i);
            tree = new string('*', j);
            Console.WriteLine("{0}{1}{0}", sky, tree);
        }
        sky = new string('.', n - 2);
        tree = new string('*', 1);
        Console.WriteLine("{0}{1}{0}", sky, tree);
    }
}
