using System;

class IntArray
{
    /* Write a program that allocates array of 20 integers and initializes
     * each element by its index multiplied by 5. Print the obtained array
     * on the console.
     */

    static void Main()
    {
        int[] a = new int[20];
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = i * 5;
        }
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine("a[{0}] = {1}", i, a[i]);
        }
    }
}