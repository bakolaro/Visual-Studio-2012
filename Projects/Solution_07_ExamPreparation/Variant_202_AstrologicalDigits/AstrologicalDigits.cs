using System;
using System.Numerics;

class AstrologicalDigits
{
    static void Main()
    {
        // Input data
        string s = Console.ReadLine();
        BigInteger n = BigInteger.Parse(s.Replace(".", "").Replace("-", ""));
        // Calculate
        BigInteger oldAstro = n;
        BigInteger newAstro;
        do
        {
            newAstro = 0;
            while (oldAstro > 0)
            {
                newAstro += (oldAstro % 10);
                oldAstro /= 10;
            }
            oldAstro = newAstro;
        }
        while (newAstro > 9);
        // Output data
        Console.WriteLine(newAstro);
    }
}