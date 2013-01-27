using System;
using System.Globalization;
using System.Threading;

class SumSingleLineOfNumbers
{
    /* You are given a sequence of positive integer values 
     * written into a string, separated by spaces. Write a 
     * function that reads these values from given string 
     * and calculates their sum.
     */
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Type in a sequence of numbers, separated with single spaces.");
        Console.WriteLine("(There should be no space after your last number.)");
        Console.WriteLine("Then press Enter...");
        string[] input = Console.ReadLine().Split();
        double sum = 0.0;
        foreach (string item in input)
        {
            sum += double.Parse(item);
        }
        Console.WriteLine("Sum = {0}", sum);
    }
}