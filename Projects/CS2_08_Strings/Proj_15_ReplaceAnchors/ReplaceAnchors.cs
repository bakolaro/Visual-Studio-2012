using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

/* Write a program that replaces in a HTML document given as 
 * string all the tags <a href="…">…</a> with corresponding
 * tags [URL=…]…[/URL].
 */
class ReplaceAnchors
{
    static void Main()
    {
        Run("Sample.html");
    }
    public static void Run(string file)
    {
        Encoding enc = Encoding.GetEncoding(1251);
        string input = File.ReadAllText(file, enc);
        Console.WriteLine(input);
        Console.WriteLine("-----------------");

        Regex regex = new Regex(@"(<a href="")([^""]+)("">)([^<]*)(</a>)");
        MatchCollection matches = regex.Matches(input);

        string output = regex.Replace(input, ReplaceRef);
        Console.WriteLine(output);
        Console.WriteLine("==================");
    }
    public static string ReplaceRef(Match m)
    {
        return "[URL=" + m.Groups[2].Value + "]" + m.Groups[4].Value + "[/URL]";
    }
}