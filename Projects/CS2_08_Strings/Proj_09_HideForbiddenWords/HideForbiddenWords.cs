using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

/* We are given a string containing a list of forbidden 
 * words and a text containing some of these words. Write
 * a program that replaces the forbidden words with asterisks.
 */
class HideForbiddenWords
{
    public static void Main()
    {
        Run("Text.txt", "ForbiddenWords.txt");
    }
    public static void Run(string fileIn, string words)
    {
        Encoding enc = Encoding.GetEncoding(1251);
        string input = File.ReadAllText(fileIn, enc);
        string[] forbidden = File.ReadAllLines(words, enc);

        string output = input;
        foreach (string word in forbidden)
        {
            Regex regex = new Regex(@"\b" + word + @"\b");
            output = regex.Replace(output, ReplaceWithStars);
        }
        Console.WriteLine(input);
        Console.WriteLine("-------------------");
        Console.Write("List of forbidden words:");
        foreach (string item in forbidden)
        {
            Console.Write(" " + item + ";");
        }
        Console.WriteLine();
        Console.WriteLine("-------------------");
        Console.WriteLine(output);
        Console.WriteLine("===================");
    }
    public static string ReplaceWithStars(Match m)
    {
        return "".PadRight(m.Value.Length, '*');
    }
}