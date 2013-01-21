using System;
using System.Text;

class BinToHex
{
    static void Main()
    {
        Console.WriteLine("Numeral system base = 2");
        Console.Write("Input an integer, n = ");
        string line = Console.ReadLine();
        Console.WriteLine("Numeral system base = 16");
        Console.Write("n = ");
        ConvertBinToHex(line);
    }
    public static void ConvertBinToHex(string bin)
    {
        StringBuilder hex = new StringBuilder();
        string binPad = bin.TrimStart(new char[] { '-' }).PadLeft((bin.Length / 4 + 1) * 4, '0');
        for (int i = 0; i < binPad.Length; i += 4)
        {
            switch (binPad.Substring(i, 4))
            {
                case "0000": hex.Append('0'); break;
                case "0001": hex.Append('1'); break;
                case "0010": hex.Append('2'); break;
                case "0011": hex.Append('3'); break;
                case "0100": hex.Append('4'); break;
                case "0101": hex.Append('5'); break;
                case "0110": hex.Append('6'); break;
                case "0111": hex.Append('7'); break;
                case "1000": hex.Append('8'); break;
                case "1001": hex.Append('9'); break;
                case "1010": hex.Append('A'); break;
                case "1011": hex.Append('B'); break;
                case "1100": hex.Append('C'); break;
                case "1101": hex.Append('D'); break;
                case "1110": hex.Append('E'); break;
                case "1111": hex.Append('F'); break;
                default: throw new Exception("Not a valid integer!");
            }
        }
        string hexTrim = hex.ToString().TrimStart(new char[] { '0' });
        if (hexTrim.Length == 0)
        {
            hexTrim = "0";
        }
        if (bin[0] == '-')
        {
            Console.WriteLine("-{0}", hexTrim);
        }
        else
        {
            Console.WriteLine("{0}", hexTrim);
        }
    }
}
