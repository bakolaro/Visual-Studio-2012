using System;

class EnglishDigitNames
{
    static void Main()
    {
        /* Write program that asks for a digit and depending on the input shows 
         * the name of that digit (in English) using a switch statement.
         */

        // About
        Console.WriteLine("Show digit name:");
        // Input data
        Console.Write("Digit = ");
        char digit = Console.ReadKey(false).KeyChar;
        Console.WriteLine();
        // Calculate
        string digitName;
        switch (digit)
        {
            case '0': digitName = "zero"; break;
            case '1': digitName = "one"; break;
            case '2': digitName = "two"; break;
            case '3': digitName = "three"; break;
            case '4': digitName = "four"; break;
            case '5': digitName = "five"; break;
            case '6': digitName = "six"; break;
            case '7': digitName = "seven"; break;
            case '8': digitName = "eight"; break;
            case '9': digitName = "nine"; break;
            default: digitName = "not a digit!"; break;
        }
        // Output data
        Console.WriteLine("{0} is {1}", digit, digitName);
    }
}

