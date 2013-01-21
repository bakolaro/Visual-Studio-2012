using System;
using System.Text;

class HexToBin
{
    static void Main()
    {
        Console.WriteLine("Numeral system base = 16");
        Console.Write("Input an integer, n = ");
        string line = Console.ReadLine();
        Console.WriteLine("Numeral system base = 2");
        Console.Write("n = ");
        ConvertHexToBin(line);
    }
    public static void ConvertHexToBin(string hex)
    {
        string hexCaps = hex.ToUpper();
        StringBuilder bin = new StringBuilder();
        foreach (char c in hexCaps)
        {
            switch (c)
            {
                case '0': bin.Append("0000"); break;
                case '1': bin.Append("0001"); break;
                case '2': bin.Append("0010"); break;
                case '3': bin.Append("0011"); break;
                case '4': bin.Append("0100"); break;
                case '5': bin.Append("0101"); break;
                case '6': bin.Append("0110"); break;
                case '7': bin.Append("0111"); break;
                case '8': bin.Append("1000"); break;
                case '9': bin.Append("1001"); break;
                case 'A': bin.Append("1010"); break;
                case 'B': bin.Append("1011"); break;
                case 'C': bin.Append("1100"); break;
                case 'D': bin.Append("1101"); break;
                case 'E': bin.Append("1110"); break;
                case 'F': bin.Append("1111"); break;
                case '-': break;
                default: throw new Exception("Not a valid integer!");
            }
        }
        string binTrim = bin.ToString().TrimStart(new char[] { '0' });
        if (binTrim.Length == 0)
        {
            binTrim = "0";
        }
        if (hex[0] == '-')
        {
            Console.WriteLine("-{0}", binTrim);
        }
        else
        {
            Console.WriteLine("{0}", binTrim);
        }
    }
}