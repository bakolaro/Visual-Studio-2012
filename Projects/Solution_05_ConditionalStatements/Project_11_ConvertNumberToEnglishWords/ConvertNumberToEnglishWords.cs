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
        Console.WriteLine(SayNumber(n));
        // Test
        Console.WriteLine(SayNumber(111));
        Console.WriteLine(SayNumber(101));
        Console.WriteLine(SayNumber(124));
        Console.WriteLine(SayNumber(24));
        Console.WriteLine(SayNumber(4));
        Console.WriteLine(SayNumber(0));
        Console.WriteLine(SayNumber(10));
        Console.WriteLine(SayNumber(220));
        Console.WriteLine(SayNumber(800));
    }

    static string SayNumber(int n)
    {
        int hundreds = n / 100;
        int tens = (n / 10) % 10;
        int ones = n % 10;
        string sayHundreds = string.Empty;
        string sayAnd = string.Empty;
        string sayBefore = string.Empty;
        string sayTens = string.Empty;
        string sayAfter = string.Empty;
        string sayOnes = string.Empty;
        string sayTenToTeens = string.Empty;
        string sayZero = string.Empty;
        switch (hundreds)
        {
            case 1: sayHundreds = "one hundred"; break;
            case 2: sayHundreds = "two hundred"; break;
            case 3: sayHundreds = "three hundred"; break;
            case 4: sayHundreds = "four hundred"; break;
            case 5: sayHundreds = "five hundred"; break;
            case 6: sayHundreds = "six hundred"; break;
            case 7: sayHundreds = "seven hundred"; break;
            case 8: sayHundreds = "eight hundred"; break;
            case 9: sayHundreds = "nine hundred"; break;
        }
        switch (tens)
        {
            case 1:
                switch (ones)
                {
                    case 0: sayTenToTeens = "ten"; break;
                    case 1: sayTenToTeens = "eleven"; break;
                    case 2: sayTenToTeens = "twelve"; break;
                    case 3: sayTenToTeens = "thirteen"; break;
                    case 4: sayTenToTeens = "fourteen"; break;
                    case 5: sayTenToTeens = "fifteen"; break;
                    case 6: sayTenToTeens = "sixteen"; break;
                    case 7: sayTenToTeens = "seventeen"; break;
                    case 8: sayTenToTeens = "eighteen"; break;
                    case 9: sayTenToTeens = "nineteen"; break;
                }
                break;
            case 2: sayTens = "twenty"; break;
            case 3: sayTens = "thirty"; break;
            case 4: sayTens = "fourty"; break;
            case 5: sayTens = "fifty"; break;
            case 6: sayTens = "sixty"; break;
            case 7: sayTens = "seventy"; break;
            case 8: sayTens = "eighty"; break;
            case 9: sayTens = "ninety"; break;
        }
        if (tens != 1)
        {
            switch (ones)
            {
                case 1: sayOnes = "one"; break;
                case 2: sayOnes = "two"; break;
                case 3: sayOnes = "three"; break;
                case 4: sayOnes = "four"; break;
                case 5: sayOnes = "five"; break;
                case 6: sayOnes = "six"; break;
                case 7: sayOnes = "seven"; break;
                case 8: sayOnes = "eight"; break;
                case 9: sayOnes = "nine"; break;
            }
        }
        if (hundreds + tens + ones == 0)
        {
            sayZero = "zero";
        }
        else if (hundreds > 0 && (tens == 1 || (tens > 0 ^ ones > 0)))
        {
            sayAnd = " and ";
        }
        else if(tens > 1)
        {
            if (hundreds > 0)
            {
                sayBefore = " ";
            }
            if (ones > 0)
            {
                sayAfter = " ";
            }

        }
        return sayHundreds + sayAnd + sayBefore + sayTens + sayAfter + sayOnes + sayTenToTeens + sayZero;
    }
}
