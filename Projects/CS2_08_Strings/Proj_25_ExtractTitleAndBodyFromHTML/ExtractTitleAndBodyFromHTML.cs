using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

/* Write a program that extracts from given HTML file
its title (if available), and its body text without the HTML tags.
*/
public class ExtractTitleAndBodyFromHTML
{
    public static void Main()
    {
        Run("Html.html", "Html.txt");
        Run("Cyrillic.html", "Cyrillic.txt");
    }
    public static void Run(string fileIn, string fileOut)
    {
        Encoding enc = Encoding.GetEncoding(1251);
        string input = File.ReadAllText(fileIn, enc);
        StringBuilder sb = new StringBuilder();
        Regex title = new Regex(@"(?<=(<title[^><]*>))[^><]*(?=(</title>))");
        sb.AppendLine(title.Match(input).Value);
        Regex bodyTag = new Regex(@"<body[^><]*>");
        int startBodyTag = bodyTag.Match(input).Index;
        Regex textContent = new Regex(@"(?<=>)[^><]+(?=<)");
        MatchCollection bodyTextContent = textContent.Matches(input, startBodyTag);
        foreach (Match m in bodyTextContent)
        {
            sb.Append(m.Value);
        }
        File.WriteAllText(fileOut, sb.ToString(), enc);
    }
}
