using System;

class BinToDec
{
    static void Main()
    {
        Console.WriteLine("Numeral system base = 2");
        Console.Write("Input an integer, n = ");
        string line = Console.ReadLine();
        Console.WriteLine("Numeral system base = 10");
        Console.Write("n = ");
        ConvertBinToDec(line);
    }
    public static void ConvertBinToDec(string bin)
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
            else if (c != '-')
            {
                throw new Exception("Not a valid integer!");
            }
        }
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