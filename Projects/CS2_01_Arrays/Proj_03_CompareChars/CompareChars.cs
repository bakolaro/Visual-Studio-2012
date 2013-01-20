using System;

class CompareChars
{
    /* Write a program that compares two char arrays
     * lexicographically (letter by letter).
     */

    static void Main()
    {
        Console.Write("First char array (string) = ");
        string s = Console.ReadLine();
        Console.Write("Second char array (string) = ");
        string t = Console.ReadLine();
        Console.WriteLine("Strings in lexical order:");
        int i = 0;
        while(i < s.Length && i < t.Length)
        {
            if (s[i] < t[i])
            {
                Console.WriteLine("{0} < {1}", s, t);
                return;
            }
            else if (s[i] > t[i])
            {
                Console.WriteLine("{0} > {1}", s, t);
                return;
            }
            i++;
        }
        if (s.Length < t.Length)
        {
            Console.WriteLine("{0} < {1}", s, t);
            return;
        }
        else if (s.Length > t.Length)
        {
            Console.WriteLine("{0} > {1}", s, t);
            return;
        }
        else
        {
            Console.WriteLine("{0} = {1}", s, t);
            return;
        }
    }    
}
