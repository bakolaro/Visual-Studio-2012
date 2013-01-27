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
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("{0} is a leap year.", year);
        }
        else
        {
            Console.WriteLine("{0} is NOT a leap year.", year);
        }
        
    }
}