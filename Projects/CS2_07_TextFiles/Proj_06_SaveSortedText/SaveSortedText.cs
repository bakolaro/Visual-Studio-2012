using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class SaveSortedText
{
    /* Write a program that reads a text file containing a list
     * of strings, sorts them and saves them to another text file.
     */
    static void Main()
    {
        Encoding enc = Encoding.GetEncoding(1251);
        StreamReader inStream = new StreamReader("List.txt", enc);
        using (inStream)
        {
            List<string> input = new List<string>();
            string line = inStream.ReadLine();
            while (line != null)
            {
                input.Add(line);
                line = inStream.ReadLine();
            }
            input.Sort();
            StreamWriter outStream = new StreamWriter("SortedList.txt", false, enc);
            using (outStream)
            {
                foreach (string s in input)
                {
                    outStream.WriteLine(s);
                }
            }
        }
        Console.WriteLine("Paragraphs of List.txt were copied to SortedList.txt in ascending order.");
    }
}