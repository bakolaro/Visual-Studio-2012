using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

class ReplaceWholeWords
{
    /* Modify the solution of the previous problem to replace 
     * only whole words (not substrings). 
     */
    static void Main()
    {
        DateTime startTime = DateTime.Now;

        string file = "LargeText.txt";
        string tempFile = Path.GetTempFileName();

        string lookFor = "start";
        Regex lookForLastRegEx = new Regex(@"\bstart\b", RegexOptions.RightToLeft);
        Regex lookForRegEx = new Regex(@"\bstart\b");
        string replaceWith = "finish";

        int bufferSize = 4096, readSize = 2048;
        Encoding enc = Encoding.GetEncoding(1251);
        StreamReader reader = new StreamReader(file, enc, false, bufferSize);
        StreamWriter writer = new StreamWriter(tempFile, false, enc);
        using (reader)
        {
            using (writer)
            {
                char[] buffer = new char[bufferSize];
                int x;
                char[] remainder = new char[0];
                while ((x = reader.Read(buffer, remainder.Length, readSize)) > 0)
                {
                    // next lines of code provide a solution for those cases when
                    // the substring goes outside the upper bound of the buffer
                    string lookIn = new string(buffer, 0, remainder.Length + x);
                    
                    Match m = lookForLastRegEx.Match(lookIn);
                    int remainderIndex;
                    if (m.Success)
                    {
                        int lookForLastIndex = m.Index;
                        if (lookForLastIndex + lookFor.Length == lookIn.Length)
                        {
                            remainderIndex = lookForLastIndex;
                        }
                        else // lookForLastIndex + lookFor.Length < lookIn.Length
                        {
                            remainderIndex = Math.Max(lookForLastIndex + lookFor.Length,
                                lookIn.Length - lookFor.Length + 1);
                        }
                    }
                    else if (lookIn.Length > lookFor.Length)
                    {
                        remainderIndex = lookIn.Length - lookFor.Length + 1;
                    }
                    else
                    {
                        remainderIndex = 0;
                    }
                    //
                    if (remainderIndex < lookIn.Length)
                    {
                        remainder = lookIn.Substring(remainderIndex).ToCharArray();
                        remainder.CopyTo(buffer, 0);
                        lookIn = lookIn.Remove(remainderIndex);
                    }
                    else
                    {
                        remainder = new char[0];
                    }
                    //
                    writer.Write(lookForRegEx.Replace(lookIn, replaceWith));
                }
                writer.Write(lookForRegEx.Replace(new string(remainder), replaceWith));
            }
        }
        File.Delete(file);
        File.Move(tempFile, file);

        DateTime endTime = DateTime.Now;
        Console.WriteLine(endTime - startTime);
    }
}