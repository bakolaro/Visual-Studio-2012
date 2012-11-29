using System;

class ConvertNumberToEnglishWords
{
    static void Main()
    {
        /* Write a program that converts a number in the range [0...999] 
         * to a text corresponding to its English pronunciation. Examples:
         * 0 -> "Zero"
         * 273 -> "Two hundred seventy three"
         * 400 -> "Four hundred"
         * 501 -> "Five hundred and one"
         * 711 -> "Seven hundred and eleven"
         */

        // About
        Console.WriteLine("Translate a number [0..999] in English:");
        // Input data
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        // Output data
        if (n < 0 || n > 999)
        {
            Console.WriteLine("Invalid data!");
            return;
        }
        Console.WriteLine("{0} is '{1}'", n, SayNumber(n));
    }

    static string SayNumber(int n)
    {
        string sayNumber = string.Empty;
        if (n == 0)
        {
            sayNumber = "zero";
        }
        else
        {
            int hundreds = n / 100;
            int tens = (n / 10) % 10;
            int ones = n % 10;
            if(hundreds > 0)
            {
                switch (hundreds)
                {
                    case 1: sayNumber = "one hundred"; break;
                    case 2: sayNumber = "two hundred"; break;
                    case 3: sayNumber = "three hundred"; break;
                    case 4: sayNumber = "four hundred"; break;
                    case 5: sayNumber = "five hundred"; break;
                    case 6: sayNumber = "six hundred"; break;
                    case 7: sayNumber = "seven hundred"; break;
                    case 8: sayNumber = "eight hundred"; break;
                    case 9: sayNumber = "nine hundred"; break;
                }
                if(tens > 0 || ones > 0)
                {
                    if(tens > 1 && ones > 0)
                    {
                        sayNumber += " ";
                    }
                    else
                    {
                        sayNumber += " and ";
                    }
                }
            }
            if (tens == 1)
            {
                switch (ones)
                {
                    case 0: sayNumber += "ten"; break;
                    case 1: sayNumber += "eleven"; break;
                    case 2: sayNumber += "twelve"; break;
                    case 3: sayNumber += "thirteen"; break;
                    case 4: sayNumber += "fourteen"; break;
                    case 5: sayNumber += "fifteen"; break;
                    case 6: sayNumber += "sixteen"; break;
                    case 7: sayNumber += "seventeen"; break;
                    case 8: sayNumber += "eighteen"; break;
                    case 9: sayNumber += "nineteen"; break;
                }
            }
            else
            {
                switch (tens)
                {
                    case 2: sayNumber += "twenty"; break;
                    case 3: sayNumber += "thirty"; break;
                    case 4: sayNumber += "fourty"; break;
                    case 5: sayNumber += "fifty"; break;
                    case 6: sayNumber += "sixty"; break;
                    case 7: sayNumber += "seventy"; break;
                    case 8: sayNumber += "eighty"; break;
                    case 9: sayNumber += "ninety"; break;
                }
                if (tens > 1 && ones > 0)
                {
                    sayNumber += " ";
                }
                switch (ones)
                {
                    case 1: sayNumber += "one"; break;
                    case 2: sayNumber += "two"; break;
                    case 3: sayNumber += "three"; break;
                    case 4: sayNumber += "four"; break;
                    case 5: sayNumber += "five"; break;
                    case 6: sayNumber += "six"; break;
                    case 7: sayNumber += "seven"; break;
                    case 8: sayNumber += "eight"; break;
                    case 9: sayNumber += "nine"; break;
                }
            }
        }
        return sayNumber;
    }
}
