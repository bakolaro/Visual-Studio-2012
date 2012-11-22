using System;

class ForestRoad
{
    static void Main()
    {
        // Input data
        int n = int.Parse(Console.ReadLine()); // n belongs to [2..79]
        int height = n + n - 1;
        char pathChar = '*';
        char treeChar = '.';
        string east, west;
        // Calculate and output data
        for (int i = 0; i < n; i++)
        {
            west = new string(treeChar, i);
            east = new string(treeChar, n - i - 1);
            Console.WriteLine(west + pathChar + east);
        }
        for (int i = 0; i < n - 1; i++)
        {
            west = new string(treeChar, n - i - 2);
            east = new string(treeChar, i + 1);
            Console.WriteLine(west + pathChar + east);
        }
    }
}