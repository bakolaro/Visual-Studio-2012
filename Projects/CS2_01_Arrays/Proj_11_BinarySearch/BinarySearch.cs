using System;

class BinarySearch
{
    static void Main()
    {
        // Input data
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Input values in ascending order:");
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("a[{0}] = ", i);
            a[i] = int.Parse(Console.ReadLine());
            if (i > 0 && a[i] < a[i - 1])
            {
                i--;
            }
        }
        Console.Write("value = ");
        int value = int.Parse(Console.ReadLine());
        // Calculate
        int start = 0;
        int end = n - 1;
        int index = (end - start) / 2 + start;
        while(index < n)
        {
            if (a[index] == value)
            {
                Console.WriteLine("a[{0}] = {1}", index, a[index]);
                return;
            }
            else if(start == end)
            {
                Console.WriteLine("No such element!");
                return;
            }
            else if (a[index] < value)
            {
                start = index + 1;
            }
            else
            {
                end = index - 1;
            }
            index = (end - start) / 2 + start;
        }
    }
}