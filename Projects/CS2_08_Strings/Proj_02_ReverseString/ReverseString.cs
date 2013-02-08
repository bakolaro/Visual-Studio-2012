using System;
using System.Text;

/* Write a program that reads a string, reverses it
and prints the result at the console.
*/

public class ReverseString
{
    public static void Main()
    {
        Console.Write("String = ");
        string s = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }
        Console.WriteLine(sb.ToString());
    }
}