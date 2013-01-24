using System;
using System.Text;
using System.IO;

class InsertLineNumbers
{
    /* Write a program that reads a text file and inserts line numbers 
     * in front of each of its lines. The result should be written to
     * another text file.
     */
    static void Main()
    {
        Encoding enc = Encoding.GetEncoding(1251);
        StreamWriter outStream = new StreamWriter("TextWithLineNumbers.txt", false, enc);
        using (outStream)
        {
            StreamReader inStream = new StreamReader("Text.txt", enc);
            using (inStream)
            {
                string line = inStream.ReadLine();
                int count = 0;
                while (line != null)
                {
                    count++;
                    outStream.WriteLine("{0,5}. | {1}", count, line);
                    line = inStream.ReadLine();
                }
            }
        }
        Console.WriteLine(@"The content of Text.txt was exported to TextWithLineNumbers.txt
and line numbers were inserted.");
    }
}
