using System;
using System.Text;
using System.IO;

class CountEqualLines
{
    /* Write a program that compares two text files line by line and prints the
     * number of lines that are the same and the number of lines that are different.
     * Assume the files have equal number of lines.
     */
    static void Main()
    {
        int equalLines = 0, unequalLines = 0;
        Encoding enc = Encoding.GetEncoding(1251);
        StreamReader inStream = new StreamReader("File001.txt", enc);
        using (inStream)
        {
            StreamReader inStream2 = new StreamReader("File002.txt", enc);
            using(inStream2)
            {
                string line = inStream.ReadLine();
                string line2 = inStream2.ReadLine();
                while (line != null && line2 != null)
                {
                    if (line.Equals(line2))
                    {
                        equalLines++;
                    }
                    else
                    {
                        unequalLines++;
                    }
                    line = inStream.ReadLine();
                    line2 = inStream2.ReadLine();
                }
            }
        }
        Console.WriteLine(@"File001.txt and File002.txt have {0} equal lines
and {1} lines that are not equal.", equalLines, unequalLines);
    }
}