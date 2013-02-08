using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

/* You are given a text. Write a program that changes the text
 * in all regions surrounded by the tags <upcase> and </upcase>
 * to uppercase. The tags cannot be nested.
 */
class ToUpperCase
{
    public static void Main()
    {
        Run("ToUpperCase.txt");
    }
    public static void Run(string fileIn)
    {
        Encoding enc = Encoding.GetEncoding(1251);
        string input = File.ReadAllText(fileIn, enc);
        Regex toCapitalize = new Regex(@"(?<=(<upcase>))[^\n]*(?=(</upcase>))");

        string output = toCapitalize.Replace(input, Capitalize).Replace("<upcase>", "").Replace("</upcase>", "");
        Console.WriteLine(input);
        Console.WriteLine("-------------------");
        Console.WriteLine(output);
        Console.WriteLine("===================");
    }
    public static string Capitalize(Match m)
    {
        return m.Value.ToUpper();
    }
}