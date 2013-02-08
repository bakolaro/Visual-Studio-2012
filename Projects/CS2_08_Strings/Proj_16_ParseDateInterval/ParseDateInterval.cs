using System;
using System.Globalization;

/* Write a program that reads two dates in the 
 * format: day.month.year and calculates the 
 * number of days between them.
 */
class ParseDateInterval
{
    static void Main()
    {
        Console.Write("Enter the first date: ");
        string dateFromText = Console.ReadLine();
        Console.Write("Enter the second date: ");
        string dateToText = Console.ReadLine();
        DateTime from = DateTime.ParseExact(dateFromText, "dd.mm.yyyy", CultureInfo.InvariantCulture).Date;
        DateTime to = DateTime.ParseExact(dateToText, "dd.mm.yyyy", CultureInfo.InvariantCulture).Date;
        Console.WriteLine("Total days between {0} and {1}: {2}", from, to, (int)((to - from).TotalDays));
    }
}