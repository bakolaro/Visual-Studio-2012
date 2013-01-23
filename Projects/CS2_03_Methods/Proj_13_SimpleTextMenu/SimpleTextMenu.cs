using System;

// Add references to project 07.

class SimpleTextMenu
{
    /* Write a program that can solve these tasks:
     * - Reverses the digits of a number
     * - Calculates the average of a sequence of integers
     * - Solves a linear equation a * x + b = 0
	 * Create appropriate methods.
	 * Provide a simple text-based menu for the user to choose which task to solve.
	 * Validate the input data:
     * - The decimal number should be non-negative
     * - The sequence should not be empty
     * - a should not be equal to 0
     */
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose an option and press a key:");
            Console.WriteLine("[1] Reverse digits of a positive integer.");
            Console.WriteLine("[2] Calculate average of some integers.");
            Console.WriteLine("[3] Solve a linear equation.");
            Console.WriteLine("[9] Quit.");
            char ch = Console.ReadKey(true).KeyChar;
            switch (ch)
            {
                case '1':
                    ReverseDigitsOfPositiveInteger();
                    break;
                case '2':
                    GetAverageOfIntegers();
                    break;
                case '3':
                    SolveLinearEquation();
                    break;
                case '9': return;
            }
            Console.WriteLine();
        }
    }
    public static void SolveLinearEquation()
    {
        Console.Write("Solve a linear equation (ax + b = 0), a = ");
        double a = int.Parse(Console.ReadLine());
        Console.Write("Solve a linear equation (ax + b = 0), b = ");
        double b = int.Parse(Console.ReadLine());
        if (a != 0)
        {
            Console.WriteLine("x = {0}", -b / a);
        }
        else if (b == 0)
        {
            Console.WriteLine("Every real number is a solution!");
        }
        else
        {
            Console.WriteLine("The equation has no solutions!");
        }
    }
    public static void ReverseDigitsOfPositiveInteger()
    {
        Console.Write("A positive integer, n = ");
        int n = int.Parse(Console.ReadLine());
        int r = ReverseDigits.ReverseIntegerDigits(n);
        Console.WriteLine("Reversed n = {0}", r);
    }
    public static void GetAverageOfIntegers()
    {
        Console.Write("A non-empty sequence of integers: ");
        string[] input = Console.ReadLine().Split();
        if (input.Length > 0)
        {
            int sum = 0;
            int count = 0;
            foreach (string item in input)
            {
                sum += int.Parse(item);
                count++;
            }
            Console.WriteLine("Average = {0}", sum / (double)count);
        }
        else
        {
            Console.WriteLine("Empty sequence!");
        }
    }
}