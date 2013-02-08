using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

/* Write a program that finds how many times a substring 
 * is contained in a given text (perform case insensitive search).
 */
class CountSubstringsCaseInsensitive
{
    public static void Main()
    {
        Run("CountSubstrings.txt", "in");
        Run("2.txt", "две");
    }
    public static void Run(string fileIn, string substring)
    {
        Encoding enc = Encoding.GetEncoding(1251);
        string input = File.ReadAllText(fileIn, enc);
        Regex regex = new Regex(substring, RegexOptions.IgnoreCase);

        MatchCollection matches = regex.Matches(input);
        Console.WriteLine(input);
        Console.WriteLine("-------------------");
        Console.WriteLine("{0} -> {1}", substring, matches.Count);
        Console.WriteLine("===================");
    }
}
