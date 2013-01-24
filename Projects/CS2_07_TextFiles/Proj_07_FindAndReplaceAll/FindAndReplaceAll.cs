using System;
using System.Text;
using System.IO;

class FindAndReplaceAll
{
    /* Write a program that replaces all occurrences of the substring
     * "start" with the substring "finish" in a text file. Ensure it
     * will work with large files (e.g. 100 MB).
     */
    static void Main()
    {
        /* "it is more efficient to use a buffer that is the same size as the internal
         * buffer of the stream, where the internal buffer is set to your desired
         * block size, and to always read less than the block size"
         */
        DateTime startTime = DateTime.Now;

        string file = "LargeText.txt";
        string tempFile = Path.GetTempFileName();

        string lookFor = "start";
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
                while ((x = reader.Read(buffer, 0, readSize)) > 0)
                {
                    // next lines of code provide a solution for those cases when
                    // the substring goes outside the upper bound of the buffer
                    string lookIn = new string(remainder) + new string(buffer, 0, x);
                    int lookForLastIndex = lookIn.LastIndexOf(lookFor);
                    int remainderIndex = Math.Max(lookForLastIndex + lookFor.Length,
                        lookIn.Length - lookFor.Length + 1);
                    remainder = lookIn.Substring(remainderIndex).ToCharArray();
                    if (remainderIndex < lookIn.Length)
                    {
                        lookIn = lookIn.Remove(remainderIndex);
                    }
                    //
                    writer.Write(lookIn.Replace(lookFor, replaceWith));
                }
                writer.Write((new string(remainder)).Replace(lookFor, replaceWith));
            }
        }
        File.Delete(file);
        File.Move(tempFile, file);

        DateTime endTime = DateTime.Now;
        Console.WriteLine(endTime - startTime);
    }
}
