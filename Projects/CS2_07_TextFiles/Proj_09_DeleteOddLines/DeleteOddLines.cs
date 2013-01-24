using System;
using System.Text;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        string file = "DeleteOddLines.txt";
        string tempFile = Path.GetTempFileName();
        Encoding enc = Encoding.GetEncoding(1251);
        StreamReader inStream = new StreamReader(file, enc);
        StreamWriter outStream = new StreamWriter(tempFile, true, enc);
        Console.OutputEncoding = Encoding.GetEncoding(1251);
        using (inStream)
        {
            using (outStream)
            {
                string line = inStream.ReadLine();
                bool odd = true;
                while (line != null)
                {
                    if (odd)
                    {
                        outStream.WriteLine(line);
                    }
                    odd = !odd;
                    line = inStream.ReadLine();
                }
            }
        }
        File.Delete(file);
        File.Move(tempFile, file);
    }
}