using System;
using System.IO;
using System.Text;

class SortStringsByLength
{
    /* You are given an array of strings. Write a method that sorts
     * the array by the length of its elements (the number of 
     * characters composing them).
     */
    static void Main()
    {
        string file = "Strings.txt";
        Encoding enc = Encoding.GetEncoding(1251);
        Console.WriteLine("Input a sequence of strings from {0}:", file);
        string[] input = File.ReadAllLines(file, enc);
        foreach (string s in input)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("Sort in ascending order by length of strings:");
        Array.Sort<string>(input, Compar);
        foreach (string s in input)
        {
            Console.WriteLine(s);
        }
    }
    public static int Compar(string a, string b)
    {
        if (a.Length < b.Length)
        {
            return -1;
        }
        else if (a.Length > b.Length)
        {
            return 1;
        }
        return 0;
    }
}