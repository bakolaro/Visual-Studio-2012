using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

class RemoveWordsWithPrefix
{
    /* Write a program that deletes from a text file all words 
     * that start with the prefix "test". Words contain only 
     * the symbols 0...9, a...z, A…Z, _.
     */
    static void Main()
    {
        string file = "PrefixTest.txt";
        Encoding enc = Encoding.GetEncoding(1251);
        string input = File.ReadAllText(file, enc);

        Regex remove = new Regex(@"\btest\w*\b");
        input = remove.Replace(input, string.Empty);

        string tempFile = Path.GetTempFileName();
        File.WriteAllText(tempFile, input, enc);
        File.Delete(file);
        File.Move(tempFile, file);
    }
}