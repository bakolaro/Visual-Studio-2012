using System;
using System.Text;

class UseBinSearch
{
    /* Write a program, that reads from the console an
     * array of N integers and an integer K, sorts the
     * array and using the method Array.BinSearch() finds
     * the largest number in the array which is ≤ K.
     */
    static void Main()
    {
        Console.Write("Array of integers, length = ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("a[{0}] = ", i);
            a[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort<int>(a);
        Console.Write("Integer value, k = ");
        int k = int.Parse(Console.ReadLine());
        int search = Array.BinarySearch<int>(a, k);
        if (search >= 0)
        {
            // the element is found
            Console.WriteLine("{0} is the largest value which is less than or equal to {1}", a[search], k);
        }
        else
        {
            // not found, a[~search] is greater than k
            if (~search > 0)
            {
                Console.WriteLine("{0} is the largest value which is less than or equal to {1}", a[~search - 1], k);
            }
            else
            {
                // ~search == 0
                Console.WriteLine("There is no element less than or equal to {0}", k);
            }
        }
    }
}