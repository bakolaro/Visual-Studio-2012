using System;
using System.IO;
using System.Text;

class OddLines
{
    /* Write a program that reads a text file and prints on the console its odd lines.
     */
    static void Main()
    {
        StreamReader inStream = new StreamReader("OddLines.in", Encoding.GetEncoding(1251));
        Console.OutputEncoding = Encoding.GetEncoding(1251);
        using (inStream)
        {
            string line = inStream.ReadLine();
            bool odd = true;
            while (line != null)
            {
                if (odd)
                {
                    Console.WriteLine(line);
                }
                odd = !odd;
                line = inStream.ReadLine();
            }
        }
    }
}