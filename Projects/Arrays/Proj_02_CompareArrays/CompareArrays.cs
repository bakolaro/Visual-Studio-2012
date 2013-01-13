using System;

class CompareArrays
{
    /* Write a program that reads two arrays from the console 
     * and compares them element by element.
     */
    
    static void Main()
    {
        Console.Write("First array, length = ");
        int m = int.Parse(Console.ReadLine());
        int[] a = new int[m];
        for (int i = 0; i < m; i++)
        {
            Console.Write("a[{0}] = ", i);
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Second array, length = ");
        int n = int.Parse(Console.ReadLine());
        int[] b = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("b[{0}] = ", i);
            b[i] = int.Parse(Console.ReadLine());
        }

        int j = 0;
        while (j < m && j < n)
        {
            Console.WriteLine("a[{0}] and b[{0}] are equal? {1}.", j, a[j] == b[j]);
            j++;
        }
        while (j < m)
        {
            Console.WriteLine("a[{0}] is beyond comparison.", j++);
        }
        while (j < n)
        {
            Console.WriteLine("b[{0}] is beyond comparison.", j++);
        }
    }
}
