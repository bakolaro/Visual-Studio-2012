using System;

class MissCat2011
{
    static void Main()
    {
        // Input data
        int n = int.Parse(Console.ReadLine());
        int[] jury = new int[n];
        for (int i = 0; i < n; i++)
        {
            // 1 to 10
            jury[i] = int.Parse(Console.ReadLine());
        }
        // Calculate
        int[] cats = new int[10];
        for (int i = 0; i < n; i++)
        {
            cats[jury[i] - 1]++;
        }
        int max = cats[0];
        int winner = 0;
        for (int i = 1; i < 10; i++)
        {
            if (cats[i] > max)
            {
                max = cats[i];
                winner = i;
            }
        }
        // Output data
        Console.WriteLine(winner + 1);
    }
}
