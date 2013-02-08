using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

/* Write a program that extracts from a given text all sentences
 * containing given word. Consider that the sentences are 
 * separated by "." and the words – by non-letter symbols.
 */
class ListSentencesWithGivenWord
{
    public static void Main()
    {
        Run("Sentences.txt", "език");
    }
    public static void Run(string fileIn, string word)
    {
        Encoding enc = Encoding.GetEncoding(1251);
        string input = File.ReadAllText(fileIn, enc);
        Regex regex = new Regex(@"(?<=(^|[.?!]))[^.?!]*\b" + word + @"\b[^.?!]*[.?!]", RegexOptions.Multiline);

        MatchCollection output = regex.Matches(input);
        Console.WriteLine(input);
        Console.WriteLine("-------------------");
        int count = 0;
        foreach (Match item in output)
        {
            Console.WriteLine(++count);
            Console.WriteLine(item.Value);   
        }
        Console.WriteLine("===================");
    }
}