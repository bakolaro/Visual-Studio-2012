using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

class RemoveListOfWords
{
    /* Write a program that removes from a text file all words listed
     * in given another text file. Handle all possible exceptions
     * in your methods.
     */
    static void Main()
    {
        try
        {
            string inputText = "Text.txt";
            Encoding enc = Encoding.GetEncoding(1251);
            string text = File.ReadAllText(inputText, enc);

            string inputWords = "RemoveWords.txt";
            string[] words = File.ReadAllLines(inputWords, enc);
            foreach (string line in words)
            {
                string pattern = @"\b" + line + @"\b";
                text = Regex.Replace(text, pattern, string.Empty);
            }
            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, text, enc);
            File.Delete(inputText);
            File.Move(tempFile, inputText);
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
}