using System;
using System.Text;

/* Write a program that converts a string to a sequence
 * of C# Unicode character literals. Use format strings.
 */
class UnicodeLiterals
{
    static void Main()
    {
        Console.Write("Input string = ");
        string s = Console.ReadLine();
        char[] a = s.ToCharArray();
        StringBuilder sb = new StringBuilder();
        foreach (char c in a)
        {
            sb.AppendFormat("\\u{0:x4}", (int)c);
        }
        Console.WriteLine(sb.ToString());
    }
}