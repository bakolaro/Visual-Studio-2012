using System;

class IndexOfLetters
{
    /* Write a program that creates an array containing all 
     * letters from the alphabet (A-Z). Read a word from the 
     * console and print the index of each of its letters in 
     * the array.
     */
    static void Main()
    {
        char[] abc = new char[26];
        for (int i = 0; i < 26; i++)
        {
            abc[i] = (char)(i + 65);
        }
        for (int i = 0; i < 26; i++)
        {
            Console.Write(abc[i]);
        }
        Console.WriteLine();
        Console.Write("Use only latin capital letters and " +
            " type in a single word:");
        string word = Console.ReadLine();
        foreach (char c in word)
        {
            for (int i = 0; i < 26; i++)
            {
                if (abc[i] == c)
                {
                    Console.WriteLine("{0,2}. {1}", i, c);
                    break;
                }
            }
        }
    }
}
