using System;
using System.Text;
using System.IO;

class MergeTextFiles
{
    /* Write a program that concatenates two text files into another text file.
     */
    static void Main()
    {
        Encoding enc = Encoding.GetEncoding(1251);
        StreamWriter outStream = new StreamWriter("MergedContent.txt", false, enc);
        using (outStream)
        {
            StreamReader inStream = new StreamReader("FileToMerge001.txt", enc);
            using (inStream)
            {
                outStream.WriteLine(inStream.ReadToEnd());
            }
            inStream = new StreamReader("FileToMerge002.txt", enc);
            using (inStream)
            {
                outStream.WriteLine(inStream.ReadToEnd());
            }
        }
        Console.WriteLine(@"FileToMerge001.txt and FileToMerge002.txt
were merged to MergedContent.txt");
    }
}
