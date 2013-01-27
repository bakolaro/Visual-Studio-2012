using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

class ExtractTextFromXML
{
    /* Write a program that extracts from given XML file 
     * all the text without the tags. 
     */
    static void Main()
    {
        string file = "Some.xml";
        Encoding enc = Encoding.GetEncoding(1251);
        string input = File.ReadAllText(file, enc);

        StringBuilder sb = new StringBuilder();
        Regex find = new Regex(@">[^><]*<");
        Regex ignore = new Regex(@"^>\s*<$");
        MatchCollection matches = find.Matches(input);
        foreach (Match m in matches)
        {
            if (!ignore.Match(m.Value).Success)
            {
                sb.AppendLine(m.Value.TrimStart('>').TrimEnd('<'));
            }
        }
        string destination = "Some.txt";
        string output = sb.ToString();
        File.WriteAllText(destination, output, enc);
    }
}