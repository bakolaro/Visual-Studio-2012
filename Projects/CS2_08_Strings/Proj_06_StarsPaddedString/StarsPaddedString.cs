using System;
using System.Text;

/* Write a program that reads from the console a string of 
 * maximum 20 characters. If the length of the string is 
 * less than 20, the rest of the characters should be filled
 * with '*'. Print the result string into the console.
 */
class StarsPaddedString
{
    public static void Main()
    {
        Run();
    }
    public static void Run()
    {
        Encoding enc = Encoding.GetEncoding(1251);
        Console.InputEncoding = enc;
        Console.OutputEncoding = enc;
        Console.WriteLine("Input string (max 20 characters) = ");
        string input = Console.ReadLine();

        string output = input;
        if(output.Length > 20)
        {
            output = output.Substring(0, 20);
        }
        else
        {
            output = output.PadRight(20, '*');
        }
        Console.WriteLine(input);
        Console.WriteLine("-------------------");
        Console.WriteLine(output);
        Console.WriteLine("===================");
    }
}