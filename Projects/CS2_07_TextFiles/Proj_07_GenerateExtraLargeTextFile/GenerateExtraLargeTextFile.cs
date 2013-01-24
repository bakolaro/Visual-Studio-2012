using System;
using System.Text;
using System.IO;

class GenerateExtraLargeTextFile
{
    static void Main()
    {
        string file = "LargeText.txt";

        // 10 KB
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < 1024; i++)
        {
            str.Append("[start***]");
        }
        
        Encoding enc = Encoding.GetEncoding(1251);
        StreamWriter writer = new StreamWriter(file, false, enc);
        using (writer)
        {
            // 10 KB * 10240 = 102400 KB
            for (int i = 0; i < 1; i++)
            {
                writer.Write(str);
            }
        }
    }
}