using System;
using System.Text;

class AnyToAny
{
    static void Main()
    {
        Console.Write("Numeral system base, s = ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Input an integer, n = ");
        string line = Console.ReadLine();
        Console.Write("Numeral system base, d = ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("n = ");
        ConvertAnyToAny(line, s, d);
    }
    public static void ConvertAnyToAny(string numberIn, int numeralSystemIn, int numeralSystemOut)
    {
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
            else if (c != '-')
            {
                throw new Exception(string.Format("Not a valid integer with base {0}!", numeralSystemIn));
            }
        }
        StringBuilder numberOut = new StringBuilder();
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
        if (numberIn[0] == '-')
        {
            Console.WriteLine("-{0}", numberOut);
        }
        else
        {
            Console.WriteLine("{0}", numberOut);
        }
    }
}
