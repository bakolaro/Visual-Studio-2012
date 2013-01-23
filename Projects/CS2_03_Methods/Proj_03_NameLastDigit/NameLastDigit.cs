using System;

public class NameLastDigit
{
    public static void Main()
    {
        Console.Write("Integer, n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(GetLastDigitName(n));
    }
    public static string GetLastDigitName(int n)
    {
        if (n < 0)
        {
            n = -n;
        }
        switch (n % 10)
        {
            case 0: return "zero";
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            default: return "error";
        }
    }
}

