using System;

class HexToDec
{
    static void Main()
    {
        Console.WriteLine("Numeral system base = 16");
        Console.Write("Input an integer, n = ");
        string line = Console.ReadLine();
        Console.WriteLine("Numeral system base = 10");
        Console.Write("n = ");
        ConvertHexToDec(line);
    }
    public static void ConvertHexToDec(string hex)
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
            else if (c != '-')
            {
                throw new Exception("Not a valid integer!");
            }
        }
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