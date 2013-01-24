using System;

class LeapYear
{
    /* Write a program that reads a year from the console and checks
     * whether it is a leap. Use DateTime.
     */
    static void Main()
    {
        Console.Write("Year = ");
        int year = int.Parse(Console.ReadLine());
        DateTime jan01 = new DateTime(year, 1, 1);
        DateTime nextJan01 = new DateTime(year + 1, 1, 1);
        TimeSpan t = nextJan01 - jan01;
        if (t.Days > 365)
        {
            Console.WriteLine("{0} is a leap year.", year);
        }
        else
        {
            Console.WriteLine("{0} is NOT a leap year.", year);
        }
    }
}