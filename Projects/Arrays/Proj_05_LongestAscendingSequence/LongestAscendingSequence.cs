using System;

class LongestAscendingSequence
{
    /* Write a program that finds the maximal increasing
     * sequence in an array.
     */
    static void Main()
    {
        // Input data
        Console.Write("Array length = ");
        int m = int.Parse(Console.ReadLine());
        int[] a = new int[m];
        for (int i = 0; i < m; i++)
        {
            Console.Write("a[{0}] = ", i);
            a[i] = int.Parse(Console.ReadLine());
        }
        // Calculate
        int index = 0;
        int lastSequenceIndex = 0;
        int lastSequenceLength = 0;
        int longestSequenceIndex = 0;
        int longestSequenceLength = 0;
        while (index < m)
        {
            if (index > 0 && a[index] > a[index - 1])
            {
                lastSequenceLength++;
                if (lastSequenceLength > longestSequenceLength)
                {
                    longestSequenceLength = lastSequenceLength;
                    longestSequenceIndex = lastSequenceIndex;
                }
            }
            else
            {
                lastSequenceLength = 1;
                lastSequenceIndex = index;
            }
            index++;
        }
        // Print longest "ascending" sequence on screen
        for (int i = longestSequenceIndex; i < longestSequenceIndex + longestSequenceLength; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}
