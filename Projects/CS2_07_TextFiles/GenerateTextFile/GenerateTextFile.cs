using System;
using System.Text;
using System.IO;

class GenerateTextFile
{
    static void Main()
    {
        Random rand = new Random();
        int lines = rand.Next(128);
        StringBuilder text = new StringBuilder();
        for (int i = 0; i < lines; i++)
        {
            //str.Append("[start***]");
            //str.Append("[start***][restarted][starter][restart][Start]");
            int words = rand.Next(16);
            StringBuilder line = new StringBuilder();
            for (int j = 0; j < words; j++)
            {
                int letters = rand.Next(8);
                int digits = rand.Next(4);
                StringBuilder word = new StringBuilder();
                for (int k = 0; k < letters; k++)
                {
                    char letter = (char)(rand.Next(26) + 65 + (rand.Next(5) == 0 ? 0 : 32));
                    word.Insert(rand.Next(word.Length), letter);
                }
                for (int k = 0; k < digits; k++)
                {
                    char digit = (char)(rand.Next(10) + 48);
                    word.Insert(rand.Next(word.Length), digit);
                }
                word.Insert(0, rand.Next(4) == 0 ? "test" : "protest");
                word.Insert(rand.Next(word.Length), (char)(rand.Next(16) + 32));
                word.Append((char)(rand.Next(4) == 0 ? 9 : 32));
                line.Append(word.ToString());
            }
            text.AppendLine(line.ToString());
        }

        string file = "LargeText.txt";
        Encoding enc = Encoding.GetEncoding(1251);
        StreamWriter writer = new StreamWriter(file, false, enc);
        using (writer)
        {
            for (int i = 0; i < 1; i++)
            {
                writer.Write(text);
            }
        }
    }
}