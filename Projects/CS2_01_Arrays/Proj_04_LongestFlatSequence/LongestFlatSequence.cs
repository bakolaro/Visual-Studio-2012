using System;

class LongestFlatSequence
{
    /* Write a program that finds the maximal sequence of 
     * equal elements in an array.
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
        Sequence current = new Sequence(0, 0);
        Sequence longest = new Sequence(0, 0);
        int index = 0;
        while (index < m)
        {
            if (index > 0 && a[index] == a[index - 1])
            {
                current.Length++;
                if (current.Length > longest.Length)
                {
                    longest = current;
                }
            }
            else
            {
                current = new Sequence(1, index);
            }
            index++;
        }
        // Print longest "flat" sequence on screen
        for (int i = longest.Start; i < longest.Start + longest.Length; i++)
		{
            Console.WriteLine(a[i]);
        }
    }
    public struct Sequence
    {
        public int Length, Start;
        public Sequence(int length, int start)
        {
            Length = length;
            Start = start;
        }
    }
}
