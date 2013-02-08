using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

/* Write a program that reverses the words in given sentence.
 */
class ReverseWords
{
    static void Main()
    {
        Run("Sentence.txt");
        Run("Text.txt");
        Run("Sample.txt");
    }
    public static void Run(string file)
    {
        Encoding enc = Encoding.GetEncoding(1251);
        string input = File.ReadAllText(file, enc);
        Console.WriteLine(input);
        Console.WriteLine("-----------------");

        Regex wordsPattern = new Regex(@"(?<=(^|[\s,;.:!?-]))[^\s,;.:!?-]+(?=[$\s,;.:!?-])");
        Regex spacesPattern = new Regex(@"(?<=(^|[^\s,;.:!?-]))[\s,;.:!?-]+(?=($|[^\s,;.:!?-]))");
        MatchCollection words = wordsPattern.Matches(input);
        MatchCollection spaces = spacesPattern.Matches(input);

        if (words.Count > 0 && spaces.Count > 0)
        {
            int firstWord = words[0].Index;
            int firstSpace = spaces[0].Index;
            int max = Math.Max(words.Count, spaces.Count);
            for (int i = 0; i < max; i++)
            {
                if (firstWord < firstSpace)
                {
                    Console.Write(words[words.Count - 1 - i]);
                    if (i < spaces.Count)
                    {
                        Console.Write(spaces[i]);
                    }
                }
                else
                {
                    Console.Write(spaces[i]);
                    if (i < words.Count)
                    {
                        Console.Write(words[words.Count - 1 - i]);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine(input);
        }
        Console.WriteLine();
        Console.WriteLine("==================");
    }
}