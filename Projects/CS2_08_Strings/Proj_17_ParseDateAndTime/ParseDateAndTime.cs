using System;
using System.Globalization;

/* Write a program that reads a date and time given in 
 * the format: day.month.year hour:minute:second and prints
 * the date and time after 6 hours and 30 minutes (in the same
 * format) along with the day of week in Bulgarian.
 */
class ParseDateAndTime
{
    static void Main()
    {
        Console.WriteLine("Enter date and time in format \"day.month.year hour:minute:second\": ");
        string dateTimeString = Console.ReadLine();
        DateTime t = DateTime.ParseExact(dateTimeString, "d.M.yyyy HH:mm:ss", CultureInfo.CurrentCulture);
        Console.WriteLine("{0:d.M.yyyy HH:mm:ss}", t.AddHours(6.5));
    }
}