using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class CountWords
{
    /* Write a program that reads a list of words from a file words.txt 
     * and finds how many times each of the words is contained in another
     * file test.txt. The result should be written in the file result.txt
     * and the words should be sorted by the number of their occurrences
     * in descending order. Handle all possible exceptions in your methods.
     */
    static void Main()
    {
        try
        {
            string inputText = "test.txt";
            Encoding enc = Encoding.GetEncoding(1251);
            string text = File.ReadAllText(inputText, enc);

            Dictionary<string, int> dic = new Dictionary<string, int>();
            string inputWords = "words.txt";
            string[] words = File.ReadAllLines(inputWords, enc);
            foreach (string line in words)
            {
                string pattern = @"\b" + line + @"\b";
                int count = Regex.Matches(text, pattern).Count;
                dic.Add(line, count);
            }
            Item[] items = new Item[dic.Count];
            int x = 0;
            Dictionary<string, int>.Enumerator e = dic.GetEnumerator();
            while (e.MoveNext())
            {
                items[x++] = new Item(e.Current.Key, e.Current.Value);
            }
            Array.Sort(items, CompareItems);
            StringBuilder sb = new StringBuilder();
            foreach (Item item in items)
            {
                sb.AppendFormat("{0,15} : {1,5}\r\n", item.Word, item.Count);
            }
            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, sb.ToString(), enc);
            string result = "result.txt";
            if (File.Exists(result))
            {
                File.Delete(result);
            }
            File.Move(tempFile, "result.txt");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
        }
        catch (RegexMatchTimeoutException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
        }
    }
    public struct Item
    {
        public string Word;
        public int Count;
        public Item(string word, int count)
        {
            Word = word;
            Count = count;
        }
    }
    public static int CompareItems(Item a, Item b)
    {
        if(a.Count > b.Count)
        {
            return -1;
        }
        else if (a.Count == b.Count)
        {
            return 0;
        }
        return 1;
    }
}