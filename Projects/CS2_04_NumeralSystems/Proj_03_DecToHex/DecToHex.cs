using System;
using System.Text;

class DecToHex
{
    static void Main()
    {
        Console.WriteLine("Numeral system base = 10");
        Console.Write("Input an integer, n = ");
        string line = Console.ReadLine();
        Console.WriteLine("Numeral system base = 16");
        Console.Write("n = ");
        ConvertDecToHex(line);
    }
    public static void ConvertDecToHex(string line)
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