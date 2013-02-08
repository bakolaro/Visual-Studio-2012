using System;
using System.IO;

/* Write a program to check if in a given expression
the brackets are put correctly.
*/

public class ValidateBrackets
{
    public static void Main()
    {
        string[] lines = File.ReadAllLines("Brackets.txt");
        foreach (string s in lines)
        {
            Run(s);
        }
    }
    public static void Run(string s)
    {
        Console.WriteLine(s);
        bool isValid = true;
        int openBrackets = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                openBrackets++;
            }
            else if (s[i] == ')')
            {
                openBrackets--;
            }
            if (openBrackets < 0)
            {
                isValid = false;
                break;
            }
        }
        if (openBrackets > 0)
        {
            isValid = false;
        }
        if (isValid)
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Not valid");
        }
    }
}