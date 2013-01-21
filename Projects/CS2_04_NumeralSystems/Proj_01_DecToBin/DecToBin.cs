using System;
using System.Text;

class DecToBin
{
    static void Main()
    {
        Console.WriteLine("Numeral system base = 10");
        Console.Write("Input an integer, n = ");
        string line = Console.ReadLine();
        Console.WriteLine("Numeral system base = 2");
        Console.Write("n = ");
        ConvertDecToBin(line);
    }
    public static void ConvertDecToBin(string line)
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
