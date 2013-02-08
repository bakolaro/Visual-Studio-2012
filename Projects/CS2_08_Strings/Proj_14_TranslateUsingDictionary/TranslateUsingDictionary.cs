using System;
using System.Text;
using System.IO;

/* A dictionary is stored as a sequence of text lines containing 
 * words and their explanations. Write a program that enters a 
 * word and translates it by using the dictionary.
 */
class TranslateUsingDictionary
{
    static void Main()
    {
        Run("Dictionary.txt");
    }
    public static void Run(string file)
    {
        Encoding enc = Encoding.GetEncoding(1251);
        string[] input = File.ReadAllLines(file, enc);
        string[] delimitors = { " - " };
        string[][] dictionary = new string[input.Length][];
        for (int i = 0; i < input.Length; i++)
        {
            dictionary[i] = input[i].Split(delimitors, 2, StringSplitOptions.None);
        }

        Console.Write("Word = ");
        string word = Console.ReadLine();
        bool found = false;
        for (int i = 0; i < dictionary.Length; i++)
        {
            if(word.ToLower().Equals(dictionary[i][0].ToLower()))
            {
                Console.WriteLine(dictionary[i][1]);
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("Not in the dictionary!");
        }
    }    
}