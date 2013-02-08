using System;

/* Write a program that parses an URL address given in the format:
 * [protocol]://[server]/[resource]
 * and extracts from it the [protocol], [server] and [resource] elements.
 */
class ParseURL
{
    static void Main()
    {
        string url = @"http://www.devbg.org/forum/index.php";
        string[] delimitors = { "://", "/" };
        string[] s = url.Split(delimitors, 3, StringSplitOptions.None);
        Console.WriteLine("[protocol] = {0}", s[0]);
        Console.WriteLine("[server] = {0}", s[1]);
        Console.WriteLine("[resource] = {0}", s[2]);
    }
}