using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Convert
{
    public static void Main()
    {
        Redirect.RunStrings(DecToBin, "DecToBin.in", "DecToBin.out", true, true);
        Redirect.RunStrings(BinToDec, "BinToDec.in", "BinToDec.out", true, true);
        Redirect.RunStrings(DecToHex, "DecToHex.in", "DecToHex.out", true, true);
        Redirect.RunStrings(HexToDec, "HexToDec.in", "HexToDec.out", true, true);
        Redirect.RunStrings(HexToBin, "HexToBin.in", "HexToBin.out", true, true);
        Redirect.RunStrings(BinToHex, "BinToHex.in", "BinToHex.out", true, true);
        Redirect.RunStrings(AnyToAny, "AnyToAny.in", "AnyToAny.out", true, true);

        Redirect.RunStrings(BinToHex, "Bin.in", "Hex.m", false, true);
        Redirect.RunStrings(HexToDec, "Hex.m", "Dec.m", false, true);
        Redirect.RunStrings(DecToBin, "Dec.m", "Bin.out", false, true);
        int errLine = Redirect.CompareFileContents("Bin.in", "Bin.out");
        if (errLine > 0)
        {
            Console.WriteLine("Bin -> Hex -> Dec -> Bin (error in line {0})", errLine);
        }
        else
        {
            Console.WriteLine("Bin -> Hex -> Dec -> Bin (OK)");
        }
        Redirect.RunStrings(BinToDec, "Bin.in", "Dec.mm", false, true);
        Redirect.RunStrings(DecToHex, "Dec.mm", "Hex.mm", false, true);
        Redirect.RunStrings(HexToBin, "Hex.mm", "Bin.out", false, true);
        errLine = Redirect.CompareFileContents("Bin.in", "Bin.out");
        if (errLine > 0)
        {
            Console.WriteLine("Bin -> Dec -> Hex -> Bin (error in line {0})", errLine);
        }
        else
        {
            Console.WriteLine("Bin -> Dec -> Hex -> Bin (OK)");
        }
    }
    public static void DecToBin(string line, bool showEquation)
    {
        int dec = int.Parse(line);
        StringBuilder bin = new StringBuilder();
        if (dec == 0)
        {
            bin.Insert(0, '0');
        }
        else
        {
            int q = dec;
            while (q != 0)
            {
                if (q % 2 == 0)
                {
                    bin.Insert(0, '0');
                }
                else
                {
                    bin.Insert(0, '1');
                }
                q /= 2;
            }
        }
        if (showEquation)
        {
            if (dec < 0)
            {
                Console.WriteLine("{0}(10) = -{1}(2)", dec, bin);
            }
            else
            {
                Console.WriteLine("{0}(10) = {1}(2)", dec, bin);
            }
        }
        else
        {
            if (dec < 0)
            {
                Console.WriteLine("-{0}", bin);
            }
            else
            {
                Console.WriteLine("{0}", bin);
            }
        }
    }
    public static void BinToDec(string bin, bool showEquation)
    {
        int dec = 0;
        foreach (char c in bin)
        {
            if (c == '0')
            {
                dec *= 2;
            }
            else if (c == '1')
            {
                dec *= 2;
                dec++;
            }
        }
        if(showEquation)
        {
            if (bin[0] == '-')
            {
                Console.WriteLine("{0}(2) = -{1}(10)", bin, dec);
            }
            else
            {
                Console.WriteLine("{0}(2) = {1}(10)", bin, dec);
            }
        }
        else
        {
            if (bin[0] == '-')
            {
                Console.WriteLine("-{0}", dec);
            }
            else
            {
                Console.WriteLine("{0}", dec);
            }
        }
    }
    public static void DecToHex(string line, bool showEquation)
    {
        int dec = int.Parse(line);
        StringBuilder hex = new StringBuilder();
        if (dec == 0)
        {
            hex.Insert(0, '0');
        }
        else
        {
            int q = dec;
            while (q != 0)
            {
                int residual = Math.Abs(q % 16);
                if (residual < 10)
                {
                    hex.Insert(0, (char)(48 + residual));
                }
                else
                {
                    hex.Insert(0, (char)(65 + residual - 10));
                }
                q /= 16;
            }
        }
        if (showEquation)
        {
            if (dec < 0)
            {
                Console.WriteLine("{0}(10) = -{1}(16)", dec, hex);
            }
            else
            {
                Console.WriteLine("{0}(10) = {1}(16)", dec, hex);
            }
        }
        else
        {
            if (dec < 0)
            {
                Console.WriteLine("-{0}", hex);
            }
            else
            {
                Console.WriteLine("{0}", hex);
            }
        }
    }
    public static void HexToDec(string hex, bool showEquation)
    {
        int dec = 0;
        foreach (char c in hex)
        {
            if (c >= '0' && c <= '9')
            {
                dec *= 16;
                dec += (c - 48);
            }
            else if (c >= 'A' && c <= 'F')
            {
                dec *= 16;
                dec += (c - 65 + 10);
            }
            else if (c >= 'a' && c <= 'f')
            {
                dec *= 16;
                dec += (c - 97 + 10);
            }
        }
        if (showEquation)
        {
            if (hex[0] == '-')
            {
                Console.WriteLine("{0}(16) = -{1}(10)", hex, dec);
            }
            else
            {
                Console.WriteLine("{0}(16) = {1}(10)", hex, dec);
            }
        }
        else
        {
            if (hex[0] == '-')
            {
                Console.WriteLine("-{0}", dec);
            }
            else
            {
                Console.WriteLine("{0}", dec);
            }
        }
    }
    public static void HexToBin(string hex, bool showEquation)
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
            }
        }
        string binTrim = bin.ToString().TrimStart(new char[] { '0' });
        if (binTrim.Length == 0)
        {
            binTrim = "0";
        }
        if (showEquation)
        {
            if (hex[0] == '-')
            {
                Console.WriteLine("{0}(16) = -{1}(2)", hex, binTrim);
            }
            else
            {
                Console.WriteLine("{0}(16) = {1}(2)", hex, binTrim);
            }
        }
        else
        {
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
    public static void BinToHex(string bin, bool showEquation)
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
            }
        }
        string hexTrim = hex.ToString().TrimStart(new char[] { '0' });
        if (hexTrim.Length == 0)
        {
            hexTrim = "0";
        }
        if (showEquation)
        {
            if (bin[0] == '-')
            {
                Console.WriteLine("{0}(2) = -{1}(16)", bin, hexTrim);
            }
            else
            {
                Console.WriteLine("{0}(2) = {1}(16)", bin, hexTrim);
            }
        }
        else
        {
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
    public static void AnyToAny(string line, bool showEquation)
    {
        string[] args = line.Split(' ');
        string numberIn = args[0];
        int numeralSystemIn = int.Parse(args[1]);
        int dec = 0;
        foreach (char c in numberIn)
        {
            if (c >= '0' && c <= '0' + numeralSystemIn - 1)
            {
                dec *= numeralSystemIn;
                dec += (c - 48);
            }
            else if (c >= 'A' && c <= 'A' + numeralSystemIn - 11)
            {
                dec *= numeralSystemIn;
                dec += (c - 65 + 10);
            }
            else if (c >= 'a' && c <= 'a' + numeralSystemIn - 11)
            {
                dec *= numeralSystemIn;
                dec += (c - 97 + 10);
            }
        }
        StringBuilder numberOut = new StringBuilder();
        int numeralSystemOut = int.Parse(args[2]);
        if (dec == 0)
        {
            numberOut.Insert(0, '0');
        }
        else
        {
            int q = dec;
            while (q != 0)
            {
                int residual = Math.Abs(q % numeralSystemOut);
                if (residual < 10)
                {
                    numberOut.Insert(0, (char)(48 + residual));
                }
                else
                {
                    numberOut.Insert(0, (char)(65 + residual - 10));
                }
                q /= numeralSystemOut;
            }
        }
        if (showEquation)
        {
            if (numberIn[0] == '-')
            {
                Console.WriteLine("{0}({1}) = -{2}({3})", numberIn, numeralSystemIn, numberOut, numeralSystemOut);
            }
            else
            {
                Console.WriteLine("{0}({1}) = {2}({3})", numberIn, numeralSystemIn, numberOut, numeralSystemOut);
            }
        }
        else
        {
            if (numberIn[0] == '-')
            {
                Console.WriteLine("-{0}", numberOut, numeralSystemOut);
            }
            else
            {
                Console.WriteLine("{0}", numberOut, numeralSystemOut);
            }
        }
    }
}
public class Redirect
{
    // public delegate void Action();
    public delegate void StringAction(string line, bool showEquation);
    public static void RunStrings(StringAction act, string input, string output, bool showEquation, bool display)
    {
        // Get the original IO streams
        TextReader standardReader = Console.In;
        TextWriter standardWriter = Console.Out;
        // Redirect IO
        StreamReader reader = new StreamReader(input);
        StreamWriter writer = new StreamWriter(output);
        Console.SetIn(reader);
        Console.SetOut(writer);
        //
        RunActionsOnStrings(act, showEquation);
        // Close IO streams
        reader.Close();
        writer.Close();
        // Set input and output to standard IO streams
        Console.SetIn(standardReader);
        Console.SetOut(standardWriter);
        //
        if (display)
        {
            Console.WriteLine("Redirected input ({0})", input);
            DisplayFileContent(input);
            Console.WriteLine("Redirected output ({0})", output);
            DisplayFileContent(output);
        }
    }
    public static void DisplayFileContent(string file)
    {
        StreamReader reader = new StreamReader(file);
        string line = reader.ReadLine();
        int counter = 1;
        // Input stops only at the end of the file
        while (line != null)
        {
            Console.WriteLine("{0,4} | {1}", counter++, line);
            line = reader.ReadLine();
        }
    }
    public static int CompareFileContents(string file1, string file2)
    {
        StreamReader reader1 = new StreamReader(file1);
        string line1 = reader1.ReadLine();
        StreamReader reader2 = new StreamReader(file2);
        string line2 = reader2.ReadLine();
        int counter = 1;
        // Input stops only at the end of the file
        while (line1 != null && line2 != null)
        {
            if (line1.Equals(line2))
            {
                counter++;
            }
            else
            {
                return counter;
            }
            line1 = reader1.ReadLine();
            line2 = reader2.ReadLine();
        }
        if (line1 == null && line2 == null)
        {
            return 0;
        }
        return counter;
    }
    public static void RunActionsOnStrings(StringAction strAction, bool showEquation)
    {
        string line = Console.ReadLine();
        while (line != null)
        {
            strAction(line, showEquation);
            line = Console.ReadLine();
        }
    }
}
public class StringArrays
{
    public static string[] ReadStringVector()
    {
        List<string> input = new List<string>();
        string line = Console.ReadLine();
        // Input stops at the end of the file or an empty line
        while (line != null && line.Length > 0)
        {
            input.Add(line);
            line = Console.ReadLine();
        }
        int n = input.Count;
        string[] vector = new string[n];
        for (int i = 0; i < n; i++)
        {
            vector[i] = input[i];
        }
        return vector;
    }
    public static string[][] ReadStringArray(char[] delimiters)
    {
        string[] vector = ReadStringVector();
        int m = vector.Length;
        string[][] arr = new string[m][];
        for (int i = 0; i < m; i++)
        {
            arr[i] = vector[i].Split(delimiters);
        }
        return arr;
    }
    public static string[,] ReadStringMatrix(char[] delimiters)
    {
        string[][] arr = ReadStringArray(delimiters);
        int m = arr.GetLength(0);
        int n = 0;
        for (int i = 0; i < m; i++)
        {
            int d = arr[i].Length;
            if (d > n)
            {
                n = d;
            }
        }
        string[,] matrix = new string[m, n];
        for (int i = 0; i < m; i++)
        {
            int d = arr[i].Length;
            for (int j = 0; j < d; j++)
            {
                matrix[i, j] = arr[i][j];
            }
            for (int j = d; j < n; j++)
            {
                matrix[i, j] = "";
            }
        }
        return matrix;
    }


    public static void PrintMatrix<T>(T[,] matrix)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        int maxLength = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int length = matrix[i, j].ToString().Length;
                if (length > maxLength)
                {
                    maxLength = length;
                }
            }
        }
        maxLength++;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0," + maxLength + "}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}