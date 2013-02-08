/* Problem 1 - C# Clean Code
    Pesho always writes useless comments in his code to remind him about some non-important things.
    You are given N lines with valid C# code written by Pesho. Your task is to write a program
that removes all comments and all empty lines from the given code. Empty line is a line
without C# code after removing the comments.
    Input
    The input data should be read from the console.
    The first line of the input will contain the number N of C# code lines.
    On the next N lines your program should read the C# code lines.
    The input data will always be valid and in the format described. There is no need to check it explicitly.
    Output
    The output data should be printed on the console.
    You should output only the cleaned code on the console. See the examples below.
    Constraints
    - N will be between 1 and 2000. The length of all lines will be between 0 and 1000 symbols.
    - Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.
*/
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

public class CleanCode
{
    public static void Main()
    {
        //string code = File.ReadAllText("CodeWithComments.txt");
        string code = ReadAllFromConsole();
        Regex comments = new Regex(@"(?<c>'""')|(?<q>""([^\\""\n]*(\\.)*)*"")|(?<v>@""([^""]*("""")*)*"")|(?<m>(?s)/\*.*?\*/)|(?<d>(?m)///.*$)|(?<s>(?m)//.*$)");
        string noComments = comments.Replace(code, ReplaceComments);
        Regex whiteLines = new Regex(@"(?m)^(\s)*$");
        string noWhiteLines = whiteLines.Replace(noComments, "");
        string[] lines = noWhiteLines.Split(new char[] { '\r', '\n' });
        foreach (string line in lines)
        {
            if (line.Length > 0)
            {
                Console.WriteLine(line);
            }
        }
    }
    public static string ReadAllFromConsole()
    {
        int n = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            sb.AppendLine(Console.ReadLine());
        }
        return sb.ToString();
    }
    public static string ReplaceComments(Match m)
    {
        if (m.Groups["m"].Success && m.Groups["m"].Length == m.Groups[0].Length
          || m.Groups["s"].Success && m.Groups["s"].Length == m.Groups[0].Length)
        {
            return string.Empty;
        }
        return m.Value;
    }
}
