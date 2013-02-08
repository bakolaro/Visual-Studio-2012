using System;
using System.Text;
using System.IO;

/* Write a program that encodes and decodes a string using
 * given encryption key (cipher). The key consists of a 
 * sequence of characters. The encoding/decoding is done
 * by performing XOR (exclusive or) operation over the first
 * letter of the string with the first of the key, the second
 * – with the second, etc. When the last key character is
 * reached, the next is the first.
 */
class EncodeDecode
{
    public static void Main()
    {
        Run("Encode.txt", "Key.txt");
    }
    public static void Run(string fileIn, string keyString)
    {
        Encoding enc = Encoding.GetEncoding(1251);
        string input = File.ReadAllText(fileIn, enc);
        string cipher = File.ReadAllText(keyString, enc);
        Console.OutputEncoding = enc;

        string encoded = Encode(input, cipher);
        string decoded = Encode(encoded, cipher);
        Console.WriteLine(input);
        Console.WriteLine("-------------encoded-------------");
        Console.WriteLine(encoded);
        Console.WriteLine("-------------decoded-------------");
        Console.WriteLine(decoded);
        Console.WriteLine("=================================");
    }
    public static string Encode(string text, string cipher)
    {
        char[] a = text.ToCharArray();
        StringBuilder sb = new StringBuilder();
        int index = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sb.Append((char)(a[i] ^ cipher[index < cipher.Length ? index : 0]));
            index++;
        }
        return sb.ToString();
    }
}
