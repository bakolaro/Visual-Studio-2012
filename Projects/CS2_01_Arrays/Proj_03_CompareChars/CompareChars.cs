using System;

class CompareChars
{
    /* Write a program that compares two char arrays
     * lexicographically (letter by letter).
     */

    static void Main()
    {
        Console.Write("First array of characters (a string) = ");
        char[] s = Console.ReadLine().ToCharArray();
        Console.Write("Second array of characters (another string) = ");
        char[] t = Console.ReadLine().ToCharArray();
        int index = 0;
        int result = 0;
        // 0: are equal
        // 1: s < t
        //-1: s > t
        while(index < s.Length && index < t.Length && result == 0)
        {
            if (s[index] < t[index])
            {
                result = 1;
            }
            else if (t[index] < s[index])
            {
                result = -1;
            }
            index++;
        }
        if (s.Length < t.Length && result == 0)
        {
            result = 1;
        }
        else if (s.Length > t.Length && result == 0)
        {
            result = -1;
        }
        // Output
        Console.Write("Arrays (as strings) in lexical order: ");
        if (result == 0)
        {
            Console.WriteLine("\"{0}\" and \"{1}\" are equal.", new string(s), new string(t));
        }
        else if (result > 0)
        {
            Console.WriteLine("\"{0}\" is before \"{1}\".", new string(s), new string(t));
        }
        else
        {
            Console.WriteLine("\"{0}\" is before \"{1}\".", new string(t), new string(s));
        }
    }    
}
