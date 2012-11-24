using System;

class Pillars
{
    static void Main()
    {
        // Input data
        int[] a = new int[8];
        for (int i = 0; i < 8; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }

        // Calculate
        int pillar = 8, left = 0, right = 0;
        for (int columnIndex = 7; columnIndex >= 0; columnIndex--)
        {
            left = right = 0;
            for (int rowIndex = 0; rowIndex < 8; rowIndex++)
            {
                left += CountBits(a[rowIndex], columnIndex + 1, 7);
                right += CountBits(a[rowIndex], 0, columnIndex - 1);
            }
            if(left == right)
            {
                pillar = columnIndex;
                break;
            }
        }
        // Output data
        if (pillar < 8)
        {
            Console.WriteLine(pillar);
            Console.WriteLine(left);
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    static int CountBits(int integer, int startPosition, int endPosition)
    {
        int counter = 0;
        for (int i = startPosition; i <= endPosition; i++)
        {
            if (((integer >> i) & 1) == 1)
            {
                counter++;
            }
        }
        return counter;
    }
}
